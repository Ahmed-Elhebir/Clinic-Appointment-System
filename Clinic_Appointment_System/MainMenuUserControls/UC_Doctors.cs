using Clinic_Appointment_System.Doctor;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global.DTOs.Doctor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Appointment_System.UserControls
{
    public partial class UC_Doctors : UserControl
    {
        List<DoctorListDTO> _DoctorListDTOs = DoctorService.GetAllDoctors();

        private enum enFilterDoctorListBy
        { 
            None = 0, 
            DoctorID = 1, 
            FullName = 2, 
            Specialty = 3,
            NationalNo = 4
        }

        public UC_Doctors()
        {
            InitializeComponent();
            UC_Settings.OnSettingsChanged += ThemeChanged;
        }

        private void SetColor()
        {
            this.BackColor = ThemeColors.MainBackground;
            lblTitle.ForeColor = ThemeColors.MainLabelText;
            lblDescription.ForeColor = ThemeColors.SecondaryLabelText;
            lblRecord.ForeColor = ThemeColors.SecondaryLabelText;
            lblFilterBy.ForeColor = ThemeColors.MainLabelText;

            #region TextBox Colors
            txtFilterBy.BackColor = ThemeColors.TextBoxBackColor;
            txtFilterBy.ForeColor = ThemeColors.TextBoxForeColor;
            #endregion

            #region Button Colors
            btnAddDoctor.BackColor = ThemeColors.SecondaryButtonBackground;
            btnAddDoctor.ForeColor = ThemeColors.SecondaryButtonForeground;
            #endregion

            #region DataGridView Colors
            dgvDoctorsList.BackgroundColor = ThemeColors.MainBackground;
            dgvDoctorsList.ColumnHeadersDefaultCellStyle.BackColor = ThemeColors.ColumnHeaderBackColor;
            dgvDoctorsList.ColumnHeadersDefaultCellStyle.ForeColor = ThemeColors.ColumnHeaderForeColor;
            dgvDoctorsList.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvDoctorsList.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;

            dgvDoctorsList.AlternatingRowsDefaultCellStyle.BackColor = ThemeColors.AlternatingCellBackColor;
            dgvDoctorsList.AlternatingRowsDefaultCellStyle.ForeColor = ThemeColors.AlternatingCellForeColor;
            dgvDoctorsList.AlternatingRowsDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvDoctorsList.AlternatingRowsDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;
            dgvDoctorsList.RowsDefaultCellStyle.BackColor = ThemeColors.RowsCellBackColor;
            dgvDoctorsList.RowsDefaultCellStyle.ForeColor = ThemeColors.RowsCellForeColor;
            dgvDoctorsList.RowsDefaultCellStyle.SelectionBackColor = ThemeColors.RowsCellSelectionBackColor;
            dgvDoctorsList.RowsDefaultCellStyle.SelectionForeColor = ThemeColors.RowsCellSelectionForeColor;
            #endregion
        }

        private void SetIcons()
        {
            btnAddDoctor.Image = ThemeColors.AddDoctorButtonIcon;
            addDoctorToolStripMenuItem.Image = ThemeColors.AddDoctorIcon;
            editDoctorToolStripMenuItem.Image = ThemeColors.EditDoctorIcon;
            deleteDoctorToolStripMenuItem.Image = ThemeColors.DeleteDoctorIcon;
        }

        private void ThemeChanged(object sender, SettingsEventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            SetColor();
            SetIcons();
        }

        private void _UpdateRecordLabel()
        {
            if (_DoctorListDTOs != null)
                lblRecord.Text = $"Showing {dgvDoctorsList.Rows.Count} of {_DoctorListDTOs.Count} doctors.";
            else
                lblRecord.Text = "No doctors found.";
        }

        private void _RefreshDoctorsList()
        {
            _DoctorListDTOs = DoctorService.GetAllDoctors();

            if (_DoctorListDTOs != null)
            {
                dgvDoctorsList.DataSource = _DoctorListDTOs;
                cbFilterBy.SelectedIndex = (int)enFilterDoctorListBy.None;
                _UpdateRecordLabel();
            }
            else
            {
                MessageBox.Show("Failed to retrieve doctors list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddEditDoctor frm = new AddEditDoctor();
            frm.ShowDialog();

            _RefreshDoctorsList();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((enFilterDoctorListBy)cbFilterBy.SelectedIndex == enFilterDoctorListBy.None)
            {
                dgvDoctorsList.DataSource = _DoctorListDTOs;
                _UpdateRecordLabel();
            }

            txtFilterBy.Visible = (cbFilterBy.Text != enFilterDoctorListBy.None.ToString());

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterText = txtFilterBy.Text.Trim().ToLower();

            if (_DoctorListDTOs == null || _DoctorListDTOs.Count == 0)
            {
                cbFilterBy.Enabled = false;
                txtFilterBy.Enabled = false;
                _UpdateRecordLabel();
                return;
            }

            if (string.IsNullOrWhiteSpace(FilterText))
            {
                dgvDoctorsList.DataSource = _DoctorListDTOs;
                _UpdateRecordLabel();
                return;
            }


            switch ((enFilterDoctorListBy)cbFilterBy.SelectedItem)
            {
                case enFilterDoctorListBy.None:
                    {
                        dgvDoctorsList.DataSource = _DoctorListDTOs;
                        break;
                    }

                case enFilterDoctorListBy.DoctorID:
                    {
                        dgvDoctorsList.DataSource = _DoctorListDTOs.Where(p =>
                        p.DoctorID.ToString().StartsWith(FilterText)).ToList();
                        break;
                    }
                case enFilterDoctorListBy.FullName:
                    {
                        dgvDoctorsList.DataSource = _DoctorListDTOs.Where(p =>
                        p.FullName.ToLower().Contains(FilterText)).ToList();
                        break;
                    }
                case enFilterDoctorListBy.Specialty:
                    { 
                        dgvDoctorsList.DataSource = _DoctorListDTOs.Where(p =>
                        p.SpecialtyName.ToLower().Contains(FilterText)).ToList();
                        break;
                    }
                case enFilterDoctorListBy.NationalNo:
                    {
                        dgvDoctorsList.DataSource = _DoctorListDTOs.Where(p =>
                        p.NationalNo.Contains(FilterText)).ToList();
                        break;
                    }
                default:
                    break;
            }

            _UpdateRecordLabel();
        }

        private void UC_Doctors_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            cbFilterBy.DataSource = Enum.GetValues(typeof(enFilterDoctorListBy));
            _RefreshDoctorsList();

            if (dgvDoctorsList.Rows.Count > 0)
            {
                dgvDoctorsList.Columns["DoctorID"].HeaderText = "ID";
                dgvDoctorsList.Columns["DoctorID"].Width = 50;

                dgvDoctorsList.Columns["FullName"].HeaderText = "Full name";
                dgvDoctorsList.Columns["FullName"].Width = 220;

                dgvDoctorsList.Columns["SpecialtyName"].HeaderText = "Specialty";
                dgvDoctorsList.Columns["SpecialtyName"].Width = 100;

                dgvDoctorsList.Columns["Age"].HeaderText = "Age";
                dgvDoctorsList.Columns["Age"].Width = 60;

                dgvDoctorsList.Columns["Gender"].HeaderText = "Gender";
                dgvDoctorsList.Columns["Gender"].Width = 60;

                dgvDoctorsList.Columns["CountryName"].HeaderText = "Nationality";
                dgvDoctorsList.Columns["CountryName"].Width = 100;

                dgvDoctorsList.Columns["NationalNo"].HeaderText = "National No.";
                dgvDoctorsList.Columns["NationalNo"].Width = 120;


            }
            
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditDoctor frm = new AddEditDoctor();
            frm.ShowDialog();

            _RefreshDoctorsList();
        }

        private void editDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvDoctorsList.CurrentRow.Cells[0].Value;
            AddEditDoctor frm = new AddEditDoctor(ID);
            frm.ShowDialog();

            _RefreshDoctorsList();
        }

        private void deleteDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvDoctorsList.CurrentRow.Cells[0].Value;
            DoctorService doctorService = DoctorService.FindByID(ID);

            if (doctorService == null)
            {
                MessageBox.Show($"Doctor with ID: {ID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete this doctor {doctorService.DrDTO.PersonDTO.FullName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = doctorService.Delete(ID);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDoctorsList();
                }
                else
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDoctorsList_DoubleClick(object sender, EventArgs e)
        {
            int ID = (int)dgvDoctorsList.CurrentRow.Cells[0].Value;
            AddEditDoctor frm = new AddEditDoctor(ID);
            frm.ShowDialog();

            _RefreshDoctorsList();
        }

        private void dgvDoctorsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dgvDoctorsList.ClearSelection();
                dgvDoctorsList.Rows[e.RowIndex].Selected = true;
                dgvDoctorsList.CurrentCell = dgvDoctorsList.Rows[e.RowIndex].Cells[e.ColumnIndex != -1 ? e.ColumnIndex : 0];

            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == enFilterDoctorListBy.DoctorID.ToString() || cbFilterBy.Text == enFilterDoctorListBy.NationalNo.ToString())
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void UC_Doctors_VisibleChanged(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = (int)enFilterDoctorListBy.None;
            txtFilterBy.Text = string.Empty;
        }
    }
}
