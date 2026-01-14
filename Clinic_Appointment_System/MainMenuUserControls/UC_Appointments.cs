using Clinic_Appointment_System.Appointment;
using Clinic_Appointment_System.Payment;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.Appointment;
using Clinic_Appointment_System_Global.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Appointment_System.UserControls
{
    public partial class UC_Appointments : UserControl
    {
        private AppointmentsDataResult appointmentResult = new AppointmentsDataResult(new List<AppointmentListDTO>(), -1, -1);

        private enum enFilterAppointmentListBy
        { 
            None = 0, 
            AppointmentID = 1, 
            PatientName = 2, 
            DoctorName = 3
        }

        public UC_Appointments()
        {
            InitializeComponent();
            UC_Settings.OnSettingsChanged += ThemeChanged;
        }

        public void ThemeChanged(object sender, SettingsEventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            SetColor();
            SetIcons();
        }

        public void SetColor()
        {
            this.BackColor = ThemeColors.MainBackground;

            lblTitle.ForeColor = ThemeColors.MainLabelText;
            lblDescription.ForeColor = ThemeColors.SecondaryLabelText;
            lblRecord.ForeColor = ThemeColors.SecondaryLabelText;
            lblFilterBy.ForeColor = ThemeColors.MainLabelText;

            txtFilterBy.BackColor = ThemeColors.TextBoxBackColor;
            txtFilterBy.ForeColor = ThemeColors.TextBoxForeColor;

            btnAddAppointment.BackColor = ThemeColors.SecondaryButtonBackground;
            btnAddAppointment.ForeColor = ThemeColors.SecondaryButtonForeground;

            pTodayAppointments.BackColor = ThemeColors.MainBackground;
            pPending.BackColor = ThemeColors.MainBackground;
            pInProgress.BackColor = ThemeColors.MainBackground;
            pCompleted.BackColor = ThemeColors.MainBackground;

            lblTodayAppointmnetsTitle.ForeColor = ThemeColors.MainLabelText;
            lblTodaysAppointments.ForeColor = ThemeColors.MainLabelText;
            lblPendingTitle.ForeColor = ThemeColors.MainLabelText;
            lblPending.ForeColor = ThemeColors.MainLabelText;
            lblInProgressTitle.ForeColor = ThemeColors.MainLabelText;
            lblInProgress.ForeColor = ThemeColors.MainLabelText;
            lblCompletedTitle.ForeColor = ThemeColors.MainLabelText;
            lblCompletedAppointments.ForeColor = ThemeColors.MainLabelText;

            dgvAppointmentList.BackgroundColor = ThemeColors.MainBackground;
            dgvAppointmentList.ColumnHeadersDefaultCellStyle.BackColor = ThemeColors.ColumnHeaderBackColor;
            dgvAppointmentList.ColumnHeadersDefaultCellStyle.ForeColor = ThemeColors.ColumnHeaderForeColor;
            dgvAppointmentList.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvAppointmentList.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;

            dgvAppointmentList.AlternatingRowsDefaultCellStyle.BackColor = ThemeColors.AlternatingCellBackColor;
            dgvAppointmentList.AlternatingRowsDefaultCellStyle.ForeColor = ThemeColors.AlternatingCellForeColor;
            dgvAppointmentList.AlternatingRowsDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvAppointmentList.AlternatingRowsDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;
            dgvAppointmentList.RowsDefaultCellStyle.BackColor = ThemeColors.RowsCellBackColor;
            dgvAppointmentList.RowsDefaultCellStyle.ForeColor = ThemeColors.RowsCellForeColor;
            dgvAppointmentList.RowsDefaultCellStyle.SelectionBackColor = ThemeColors.RowsCellSelectionBackColor;
            dgvAppointmentList.RowsDefaultCellStyle.SelectionForeColor= ThemeColors.RowsCellSelectionForeColor;

        }

        public void SetIcons()
        {
            pbTodayAppointments.Image = ThemeColors.TodaysAppointmnetIcon;
            pbPending.Image = ThemeColors.PendingAppointmentIcon;
            pbInProgress.Image = ThemeColors.InProgressAppointmentIcon;
            pbCompleted.Image = ThemeColors.CompletedAppointmentIcon;

            btnAddAppointment.Image = ThemeColors.AddAppointmentIconButton;

            addAppointmentToolStripMenuItem.Image = ThemeColors.AddAppointmentIcon;
            editAppointmentToolStripMenuItem.Image = ThemeColors.EditAppointmnetIcon;
            cancelAppointmentToolStripMenuItem.Image = ThemeColors.CancelledAppointmentIcon;
            completeAppointmentToolStripMenuItem.Image = ThemeColors.CompletedAppointmentItemIcon;
            payPaymentsToolStripMenuItem.Image = ThemeColors.PaymentsIcon;
        }

        private void _UpdateRecordLabel()
        {
            if (appointmentResult?.Appointments != null)
                lblRecord.Text = $"Showing {dgvAppointmentList.Rows.Count} of {appointmentResult.Appointments.Count} appointments.";
            else
                lblRecord.Text = "No appointments found.";
        }

        private void _RefreshAppointmentList()
        {
            appointmentResult = AppointmentService.GetAllAppointments();

            if (appointmentResult != null)
            {
                dgvAppointmentList.DataSource = appointmentResult.Appointments;
                lblTodaysAppointments.Text = appointmentResult.TodaysCount.ToString();
                lblCompletedAppointments.Text = appointmentResult.CompletedCount.ToString();

                cbFilterBy.SelectedIndex = (int)enFilterAppointmentListBy.None;
                _UpdateRecordLabel();
            }
            else
            {
                MessageBox.Show("Failed to retrieve appointment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddEditAppointment frm = new AddEditAppointment();
            frm.ShowDialog();

            _RefreshAppointmentList();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((enFilterAppointmentListBy)cbFilterBy.SelectedIndex == enFilterAppointmentListBy.None)
            {
                dgvAppointmentList.DataSource = appointmentResult.Appointments;
                _UpdateRecordLabel();
            }

            txtFilterBy.Visible = ((enFilterAppointmentListBy)cbFilterBy.SelectedIndex != enFilterAppointmentListBy.None);

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterString = txtFilterBy.Text.Trim().ToLower();

            if (appointmentResult.Appointments == null || appointmentResult.Appointments.Count == 0)
            {
                txtFilterBy.Enabled = false;
                cbFilterBy.Enabled = false;
                _UpdateRecordLabel();
                return;
            }

            if (string.IsNullOrEmpty(FilterString))
            {
                dgvAppointmentList.DataSource = appointmentResult.Appointments;
                _UpdateRecordLabel();
                return;
            }

            switch((enFilterAppointmentListBy)cbFilterBy.SelectedIndex)
            {
                case enFilterAppointmentListBy.None:
                    {
                        dgvAppointmentList.DataSource = appointmentResult.Appointments;
                        break;
                    }
                case enFilterAppointmentListBy.AppointmentID:
                    {
                        dgvAppointmentList.DataSource = appointmentResult.Appointments.Where(a => a.AppointmentID.ToString().StartsWith(FilterString)).ToList(); ;
                        break;
                    }
                case enFilterAppointmentListBy.PatientName:
                    {
                        dgvAppointmentList.DataSource = appointmentResult.Appointments.Where(a => a.PatientName.ToLower().Contains(FilterString)).ToList(); ;
                        break;
                    }
                case enFilterAppointmentListBy.DoctorName:
                    {
                        dgvAppointmentList.DataSource = appointmentResult.Appointments.Where(a => a.DoctorName.ToLower().Contains(FilterString)).ToList(); ;
                        break;
                    }
                default:
                    return;
            }
            _UpdateRecordLabel();
        }

        private void UC_Appointments_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            cbFilterBy.DataSource = Enum.GetValues(typeof(enFilterAppointmentListBy));
            _RefreshAppointmentList();

            if (dgvAppointmentList.Rows.Count > 0)
            {
                dgvAppointmentList.Columns["AppointmentID"].HeaderText = "ID";
                dgvAppointmentList.Columns["AppointmentID"].Width = 50;

                dgvAppointmentList.Columns["PatientName"].HeaderText = "Patient name";
                dgvAppointmentList.Columns["PatientName"].Width = 100;

                dgvAppointmentList.Columns["DoctorName"].HeaderText = "Doctor name";
                dgvAppointmentList.Columns["DoctorName"].Width = 100;

                dgvAppointmentList.Columns["AppointmentDate"].HeaderText = "Date";
                dgvAppointmentList.Columns["AppointmentDate"].Width = 70;

                dgvAppointmentList.Columns["StatusName"].HeaderText = "Status";
                dgvAppointmentList.Columns["StatusName"].Width = 60;

                dgvAppointmentList.Columns["UpdateAt"].HeaderText = "Updated at";
                dgvAppointmentList.Columns["UpdateAt"].Width = 70;

                dgvAppointmentList.Columns["CreatedAt"].HeaderText = "Created at";
                dgvAppointmentList.Columns["CreatedAt"].Width = 140;
            }
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditAppointment frm = new AddEditAppointment();
            frm.ShowDialog();

            _RefreshAppointmentList();
        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvAppointmentList.CurrentRow.Cells[0].Value;
            AddEditAppointment frm = new AddEditAppointment(ID);
            frm.ShowDialog();

            _RefreshAppointmentList();
        }

        private void dgvAppointmentList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dgvAppointmentList.ClearSelection();
                dgvAppointmentList.Rows[e.RowIndex].Selected = true;
                dgvAppointmentList.CurrentCell = dgvAppointmentList.Rows[e.RowIndex].Cells[e.ColumnIndex != -1 ? e.ColumnIndex : 0];
            }
        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvAppointmentList.CurrentRow.Cells[0].Value;
            AppointmentService appointmentService = AppointmentService.FindByID(ID);

            if (appointmentService == null)
            {
                MessageBox.Show($"Appointment with ID [{ID}] was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (appointmentService.AppointmentStatus == AppointmentStatusEnum.Cancelled)
            {
                MessageBox.Show("Appointment is already cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (MessageBox.Show($"Are you sure you want to cancel this appointment with ID [{ID}]?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                appointmentService.AppointmentStatus = AppointmentStatusEnum.Cancelled;

                var result = appointmentService.Save();

                if (result.Success)
                {
                    MessageBox.Show("Appointment cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAppointmentList();
                    return;
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred while cancelling the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dgvAppointmentList_DoubleClick(object sender, EventArgs e)
        {
            int ID = (int)dgvAppointmentList.CurrentRow.Cells[0].Value;
            AddEditAppointment frm = new AddEditAppointment(ID);
            frm.ShowDialog();

            _RefreshAppointmentList();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            int appointmentID = (int)dgvAppointmentList.CurrentRow.Cells[0].Value;
            AppointmentService appointmentService = AppointmentService.FindByID(appointmentID);

            if (appointmentService == null)
            {
                contextMenuStrip.Close();
                return;
            }

            OperationResult isPaid = PaymentService.IsPaid(appointmentID);

            cancelAppointmentToolStripMenuItem.Enabled = (appointmentService.AppointmentStatus == AppointmentStatusEnum.Scheduled);
            payPaymentsToolStripMenuItem.Enabled = (!isPaid.Success && appointmentService.AppointmentStatus == AppointmentStatusEnum.Completed);
            completeAppointmentToolStripMenuItem.Enabled = (appointmentService.AppointmentStatus == AppointmentStatusEnum.Scheduled);
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == enFilterAppointmentListBy.AppointmentID.ToString())
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void UC_Appointments_VisibleChanged(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = (int)enFilterAppointmentListBy.None;
            txtFilterBy.Text = string.Empty;
        }

        private void completeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvAppointmentList.CurrentRow.Cells[0].Value;
            AppointmentService appointmentService = AppointmentService.FindByID(ID);

            if (appointmentService == null)
            {
                MessageBox.Show($"Appointment with ID [{ID}] was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to complete this appointment with ID [{ID}]?", "Confirm completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                appointmentService.AppointmentStatus = AppointmentStatusEnum.Completed;

                var result = appointmentService.Save();

                if (result.Success)
                {
                    MessageBox.Show("Appointment completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    AddPayment frm = new AddPayment(ID);
                    frm.ShowDialog();
                    
                    _RefreshAppointmentList();
                    return;
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred while completing the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void payPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvAppointmentList.CurrentRow.Cells[0].Value;
            AddPayment frm = new AddPayment(ID);
            frm.ShowDialog();

            _RefreshAppointmentList();
        }
    }
}
