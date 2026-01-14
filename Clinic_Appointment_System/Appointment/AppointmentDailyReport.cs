using Clinic_Appointment_System.UserControls;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global;
using System;
using System.Windows.Forms;

namespace Clinic_Appointment_System.Appointment
{
    public partial class AppointmentDailyReport : Form
    {
        public AppointmentDailyReport()
        {
            InitializeComponent();
            FormDragHelper.EnableDrag(this.pFullForm);
            UC_Settings.OnSettingsChanged += ThemeChanged;
        }

        private void ThemeChanged(object sender, SettingsEventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            SetColors();
            SetIcons();
        }

        private void SetColors()
        {
            this.BackColor = ThemeColors.MainBackground;
            pFullForm.BackColor = ThemeColors.MainBackground;
            pTodayAppointment.BackColor = ThemeColors.MainBackground;
            pCompleted.BackColor = ThemeColors.MainBackground;
            pCancelled.BackColor = ThemeColors.MainBackground;

            lblTitle.ForeColor = ThemeColors.MainLabelText;
            lblFilterBy.ForeColor = ThemeColors.MainLabelText;
            lblTodaysAppointments.ForeColor = ThemeColors.MainLabelText;
            lblTodayAppointment.ForeColor = ThemeColors.MainLabelText;
            lblCompleted.ForeColor = ThemeColors.MainLabelText;
            lblCompletedAppointments.ForeColor = ThemeColors.MainLabelText;
            lblCancelled.ForeColor = ThemeColors.MainLabelText;
            lblCancelledAppointments.ForeColor = ThemeColors.MainLabelText;
            lblRecord.ForeColor = ThemeColors.SecondaryLabelText;

            btnGenerateReport.BackColor = ThemeColors.SecondaryButtonBackground;
            btnGenerateReport.ForeColor = ThemeColors.SecondaryButtonForeground;

            dgvAppointmentReportList.BackgroundColor = ThemeColors.MainBackground;
            dgvAppointmentReportList.ColumnHeadersDefaultCellStyle.BackColor = ThemeColors.ColumnHeaderBackColor;
            dgvAppointmentReportList.ColumnHeadersDefaultCellStyle.ForeColor = ThemeColors.ColumnHeaderForeColor;
            dgvAppointmentReportList.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvAppointmentReportList.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;
            
            dgvAppointmentReportList.AlternatingRowsDefaultCellStyle.BackColor = ThemeColors.AlternatingCellBackColor;
            dgvAppointmentReportList.AlternatingRowsDefaultCellStyle.ForeColor = ThemeColors.AlternatingCellForeColor;
            dgvAppointmentReportList.AlternatingRowsDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvAppointmentReportList.AlternatingRowsDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;
            dgvAppointmentReportList.RowsDefaultCellStyle.BackColor = ThemeColors.RowsCellBackColor;
            dgvAppointmentReportList.RowsDefaultCellStyle.ForeColor = ThemeColors.RowsCellForeColor;
            dgvAppointmentReportList.RowsDefaultCellStyle.SelectionBackColor = ThemeColors.RowsCellSelectionBackColor;
            dgvAppointmentReportList.RowsDefaultCellStyle.SelectionForeColor = ThemeColors.RowsCellSelectionForeColor;

        }

        private void SetIcons()
        {
            pbClose.Image = ThemeColors.CloseIcon;
            btnGenerateReport.Image = ThemeColors.GenerateDailyReportButtonIcon;
            pbTodayAppointment.Image = ThemeColors.TodaysAppointmnetIcon;
            pbCompleted.Image = ThemeColors.CompletedAppointmentIcon;
            pbCancelled.Image = ThemeColors.CancelledAppointmentIcon;
        }

        private void _ResetDefaultValues()
        {
            DateTime today = DateTime.Now;
            AppointmentReportDataResult reportData = AppointmentService.GetAppointmentReport(today);

            if (reportData == null)
            {
                MessageBox.Show("Failed to retrieve appointment report data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRecord.Text = $"Total: {reportData.ReportData.Count} appointments.";
            lblTodaysAppointments.Text = reportData.CountScheduled.ToString();
            lblCompletedAppointments.Text = reportData.CountCompleted.ToString();
            lblCancelledAppointments.Text = reportData.CountCancelled.ToString();

            dgvAppointmentReportList.DataSource = reportData.ReportData;


        }

        private void AppointmentDailyReport_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            ApplyTheme();

            if (dgvAppointmentReportList.Columns.Count > 0)
            { 
                dgvAppointmentReportList.Columns["AppointmentID"].HeaderText = "ID";
                dgvAppointmentReportList.Columns["AppointmentID"].Width = 30;
                dgvAppointmentReportList.Columns["PatientName"].HeaderText = "Patient name";
                dgvAppointmentReportList.Columns["PatientName"].Width = 130;
                dgvAppointmentReportList.Columns["DoctorName"].HeaderText = "Doctor name";
                dgvAppointmentReportList.Columns["DoctorName"].Width = 130;
                dgvAppointmentReportList.Columns["AppointmentDate"].HeaderText = "Date";
                dgvAppointmentReportList.Columns["AppointmentDate"].Width = 70;
                dgvAppointmentReportList.Columns["StatusName"].HeaderText = "Status";
                dgvAppointmentReportList.Columns["StatusName"].Width = 60;
                dgvAppointmentReportList.Columns["UserName"].HeaderText = "User Name";
                dgvAppointmentReportList.Columns["UserName"].Width = 100;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpReportDate.Value;
            AppointmentReportDataResult reportData = AppointmentService.GetAppointmentReport(selectedDate);
            if (reportData == null)
            {
                MessageBox.Show("Failed to retrieve appointment report data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRecord.Text = $"Total: {reportData.ReportData.Count} appointments.";
            lblTodaysAppointments.Text = reportData.CountScheduled.ToString();
            lblCompletedAppointments.Text = reportData.CountCompleted.ToString();
            lblCancelledAppointments.Text = reportData.CountCancelled.ToString();
            dgvAppointmentReportList.DataSource = reportData.ReportData;

            

        }
    }
}
