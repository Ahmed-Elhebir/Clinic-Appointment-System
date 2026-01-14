using Clinic_Appointment_System.Patient;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global.DTOs.Patient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Appointment_System.UserControls
{
    public partial class UC_Patients : UserControl
    {
        List<PatientListDTO> _PatientListDTOs = PatientService.GetAllPatients();

        private enum enFilterPatientListBy
        {
            None = 0,
            PatientID = 1,
            FullName = 2,
            FileNo = 3,
            NationalNo = 4
        }

        public UC_Patients()
        {
            InitializeComponent();
            UC_Settings.OnSettingsChanged += ThemeChanged;
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
            btnAddPatient.BackColor = ThemeColors.SecondaryButtonBackground;
            btnAddPatient.ForeColor = ThemeColors.SecondaryButtonForeground;
            #endregion

            #region DataGridView Colors
            dgvPatientsList.BackgroundColor = ThemeColors.MainBackground;
            dgvPatientsList.ColumnHeadersDefaultCellStyle.BackColor = ThemeColors.ColumnHeaderBackColor;
            dgvPatientsList.ColumnHeadersDefaultCellStyle.ForeColor = ThemeColors.ColumnHeaderForeColor;
            dgvPatientsList.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvPatientsList.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;
            
            dgvPatientsList.AlternatingRowsDefaultCellStyle.BackColor = ThemeColors.AlternatingCellBackColor;
            dgvPatientsList.AlternatingRowsDefaultCellStyle.ForeColor = ThemeColors.AlternatingCellForeColor;
            dgvPatientsList.AlternatingRowsDefaultCellStyle.SelectionBackColor = ThemeColors.AlternatingCellSelectionBackColor;
            dgvPatientsList.AlternatingRowsDefaultCellStyle.SelectionForeColor = ThemeColors.AlternatingCellSelectionForeColor;
            dgvPatientsList.RowsDefaultCellStyle.BackColor = ThemeColors.RowsCellBackColor;
            dgvPatientsList.RowsDefaultCellStyle.ForeColor = ThemeColors.RowsCellForeColor;
            dgvPatientsList.RowsDefaultCellStyle.SelectionBackColor = ThemeColors.RowsCellSelectionBackColor;
            dgvPatientsList.RowsDefaultCellStyle.SelectionForeColor = ThemeColors.RowsCellSelectionForeColor;
            #endregion
        }
        
        private void SetIcons()
        {
            btnAddPatient.Image = ThemeColors.AddPatientButtonIcon;
        }

        private void _UpdateRecordLabel()
        {
            if (_PatientListDTOs != null)
                lblRecord.Text = $"Showing {dgvPatientsList.Rows.Count} of {_PatientListDTOs.Count} patients.";
            else
                lblRecord.Text = "No patient found.";
        }

        private void _RefreshPatientsList()
        {
            _PatientListDTOs = PatientService.GetAllPatients();

            if (_PatientListDTOs != null)
            {
                dgvPatientsList.DataSource = _PatientListDTOs;
                cbFilterBy.SelectedIndex = (int)enFilterPatientListBy.None;
                _UpdateRecordLabel();
            }
            else
            {
                MessageBox.Show("Failed to retrieve patient list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddEditPatient frm = new AddEditPatient();
            frm.ShowDialog();

            _RefreshPatientsList();
        }

        private void UC_Patients_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            cbFilterBy.DataSource = Enum.GetValues(typeof(enFilterPatientListBy));
            _RefreshPatientsList();

            if (dgvPatientsList.Rows.Count > 0)
            {
                dgvPatientsList.Columns[0].HeaderText = "ID";
                dgvPatientsList.Columns[0].Width = 50;

                dgvPatientsList.Columns[1].HeaderText = "Full name";
                dgvPatientsList.Columns[1].Width = 220;

                dgvPatientsList.Columns[2].HeaderText = "Age";
                dgvPatientsList.Columns[2].Width = 60;

                dgvPatientsList.Columns[3].HeaderText = "File No.";
                dgvPatientsList.Columns[3].Width = 100;

                dgvPatientsList.Columns[4].HeaderText = "National No";
                dgvPatientsList.Columns[4].Width = 120;

                dgvPatientsList.Columns[5].HeaderText = "Gender";
                dgvPatientsList.Columns[5].Width = 60;

                dgvPatientsList.Columns[6].HeaderText = "Nationality";
                dgvPatientsList.Columns[6].Width = 120;

            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((enFilterPatientListBy)cbFilterBy.SelectedIndex == enFilterPatientListBy.None)
            {
                dgvPatientsList.DataSource = _PatientListDTOs;
                _UpdateRecordLabel();
            }

            txtFilterBy.Visible = (cbFilterBy.Text != enFilterPatientListBy.None.ToString());
            
            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterText = txtFilterBy.Text.Trim().ToLower();

            if (_PatientListDTOs == null || _PatientListDTOs.Count == 0)
            { 
                cbFilterBy.Enabled = false;
                txtFilterBy.Enabled = false;
                _UpdateRecordLabel();
                return;
            }

            if (string.IsNullOrWhiteSpace(FilterText))
            {
                dgvPatientsList.DataSource = _PatientListDTOs;
                _UpdateRecordLabel();
                return;
            }


            switch ((enFilterPatientListBy)cbFilterBy.SelectedItem)
            {
                case enFilterPatientListBy.None:
                    {
                        dgvPatientsList.DataSource = _PatientListDTOs;
                        break;
                    }
                case enFilterPatientListBy.PatientID:
                    {
                        dgvPatientsList.DataSource = _PatientListDTOs.Where(p =>
                        p.PatientID.ToString().StartsWith(FilterText)).ToList();
                        break;
                    }
                case enFilterPatientListBy.FullName:
                    {
                        dgvPatientsList.DataSource = _PatientListDTOs.Where(p =>
                        p.FullName.ToLower().Contains(FilterText)).ToList();
                        break;
                    }
                case enFilterPatientListBy.FileNo:
                    {
                        dgvPatientsList.DataSource = _PatientListDTOs.Where(p =>
                        p.FileNo.ToLower().Contains(FilterText)).ToList();
                        break;
                    }
                case enFilterPatientListBy.NationalNo:
                    {
                        dgvPatientsList.DataSource = _PatientListDTOs.Where(p =>
                        p.NationalNo.Contains(FilterText)).ToList();
                        break;
                    }
                default:
                    break;
            }

            _UpdateRecordLabel();
        }

        private void dgvPatientsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dgvPatientsList.ClearSelection();
                dgvPatientsList.Rows[e.RowIndex].Selected = true;
                dgvPatientsList.CurrentCell = dgvPatientsList.Rows[e.RowIndex].Cells[e.ColumnIndex != -1 ? e.ColumnIndex : 0];
            }
        }

        private void dgvPatientsList_DoubleClick(object sender, EventArgs e)
        {
            int ID = (int)dgvPatientsList.CurrentRow.Cells[0].Value;
            AddEditPatient frm = new AddEditPatient(ID);
            frm.ShowDialog();

            _RefreshPatientsList();
        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvPatientsList.CurrentRow.Cells[0].Value;
            PatientService patientService = PatientService.FindByID(ID);

            if (patientService == null)
            {
                MessageBox.Show($"Patient with ID: {ID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete this patient {patientService.PaDTO.PersonDTO.FullName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = patientService.Delete(ID);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPatientsList();
                }
                else
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvPatientsList.CurrentRow.Cells[0].Value;
            AddEditPatient frm = new AddEditPatient(ID);
            frm.ShowDialog();

            _RefreshPatientsList();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditPatient frm = new AddEditPatient();
            frm.ShowDialog();

            _RefreshPatientsList();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == enFilterPatientListBy.PatientID.ToString() || cbFilterBy.Text == enFilterPatientListBy.NationalNo.ToString())
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void UC_Patients_VisibleChanged(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = (int)enFilterPatientListBy.None;
            txtFilterBy.Text = string.Empty;
        }
    }
}
