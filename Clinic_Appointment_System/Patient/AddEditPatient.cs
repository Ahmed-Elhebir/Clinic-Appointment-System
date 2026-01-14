using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Clinic_Appointment_System.UserControls;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.Country;

namespace Clinic_Appointment_System.Patient
{
    public partial class AddEditPatient : Form
    {
        private const string DefaultCountry = "Saudi Arabia";
        private const int DefaultMaxAge = 155;
        private enum enMode { AddNew, Update }

        private enMode _Mode;
        private readonly int _PatientID;
        PatientService _patientService = new PatientService();
        PersonService _personService = new PersonService();


        public AddEditPatient()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
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

            lblAddEditTitle.ForeColor = ThemeColors.MainLabelText;
            lblDescription.ForeColor = ThemeColors.SecondaryLabelText;
            lblFirstName.ForeColor = ThemeColors.MainLabelText;
            lblSecondName.ForeColor = ThemeColors.MainLabelText;
            lblThirdName.ForeColor = ThemeColors.MainLabelText;
            lblLastName.ForeColor = ThemeColors.MainLabelText;
            lblPhoneNumber.ForeColor = ThemeColors.MainLabelText;
            lblDateOfBirth.ForeColor = ThemeColors.MainLabelText;
            lblNationality.ForeColor = ThemeColors.MainLabelText;
            lblNationalNumber.ForeColor = ThemeColors.MainLabelText;
            lblEmail.ForeColor = ThemeColors.MainLabelText;
            lblGender.ForeColor = ThemeColors.MainLabelText;

            rbMale.ForeColor = ThemeColors.MainLabelText;
            rbFemale.ForeColor = ThemeColors.MainLabelText;

            btnSave.BackColor = ThemeColors.SaveButtonBackColor;
            btnSave.ForeColor = ThemeColors.SaveButtonForeColor;
            btnCancel.BackColor = ThemeColors.CancelButtonBackColor;
            btnCancel.ForeColor = ThemeColors.CancelButtonForeColor;

        }

        private void SetIcons()
        {
            btnSave.Image = ThemeColors.SaveIcon;
            btnCancel.Image = ThemeColors.CancelIcon;
            pbClose.Image = ThemeColors.CloseIcon;
        }

        public AddEditPatient(int patientID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PatientID = patientID;
            FormDragHelper.EnableDrag(this.pFullForm);
            UC_Settings.OnSettingsChanged += ThemeChanged;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fill all required fields with valid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save logic here
            _patientService._PersonDTO.FirstName = txtFirstName.Text.Trim();
            _patientService._PersonDTO.SecondName = txtSecondName.Text.Trim();
            _patientService._PersonDTO.LastName = txtLastName.Text.Trim();
            _patientService._PersonDTO.PhoneNumber = txtPhoneNumber.Text.Trim();
            _patientService._PersonDTO.DateOfBirth = dtDateOfBirth.Value;
            _patientService._PersonDTO.NationalityCountryID = CountryService.FindByName(cbNationality.Text).CountryID;
            _patientService._PersonDTO.NationalNo = txtNationalNumber.Text.Trim();

            if (txtThirdName.Text.Trim() == "")
                _patientService._PersonDTO.ThirdName = null;
            else
                _patientService._PersonDTO.ThirdName = txtThirdName.Text.Trim();
            
            if (txtEmail.Text.Trim() == "")
                _patientService._PersonDTO.Email = null;
            else
                _patientService._PersonDTO.Email = txtEmail.Text.Trim();


            if (rbMale.Checked)
                _patientService._PersonDTO.Gender = GenderEnum.Male;
            else
                _patientService._PersonDTO.Gender = GenderEnum.Female;

            OperationResult result = _patientService.Save();
            if (result.Success)
            {
                lblAddEditTitle.Text = "Update Patient";
                this.Text = "Update Patient";
                _Mode = enMode.Update;
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _FillCountriesInComboBox()
        {
            cbNationality.Items.Clear();
            List<CountryDTO> countries = CountryService.GetAllCountries();
            foreach (var country in countries)
            {
                cbNationality.Items.Add(country.CountryName);
            }
        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Patient";
                lblAddEditTitle.Text = "Add New Patient";
            }

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";

            dtDateOfBirth.Value = DateTime.Now;
            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-DefaultMaxAge);

            cbNationality.SelectedIndex = cbNationality.FindString(DefaultCountry);
            txtNationalNumber.Text = "";
            txtEmail.Text = "";
            rbMale.Checked = true;
        }

        private void _LoadData()
        {
            _patientService = PatientService.FindByID(_PatientID);

            if (_patientService == null)
            {
                MessageBox.Show($"No patient found with this ID [{_PatientID}].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Text = "Update Patient";
            lblAddEditTitle.Text = "Update Patient";

            txtFirstName.Text = _patientService.PaDTO.PersonDTO.FirstName;
            txtSecondName.Text = _patientService.PaDTO.PersonDTO.SecondName;
            txtThirdName.Text = _patientService.PaDTO.PersonDTO.ThirdName;
            txtLastName.Text = _patientService.PaDTO.PersonDTO.LastName;
            txtPhoneNumber.Text = _patientService.PaDTO.PersonDTO.PhoneNumber;
            dtDateOfBirth.Value = _patientService.PaDTO.PersonDTO.DateOfBirth;
            cbNationality.SelectedIndex = cbNationality.FindString(CountryService.FindByID(_patientService.PaDTO.PersonDTO.NationalityCountryID).CountryName);
            txtNationalNumber.Text = _patientService.PaDTO.PersonDTO.NationalNo;
            txtEmail.Text = _patientService.PaDTO.PersonDTO.Email;

            if (_patientService.PaDTO.PersonDTO.Gender == GenderEnum.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

        }

        private void AddEditPatient_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            ApplyTheme();

            if (_Mode == enMode.Update)
                _LoadData();
            

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                errorProvider.SetError(textBox, "This field is required.");
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void ValidatePhoneNumber(object sender, CancelEventArgs e)
        {
            if (!Validation.IsValidPhoneNumber(txtPhoneNumber.Text.Trim()))
            {
                errorProvider.SetError(txtPhoneNumber, "Please enter a valid phone number.");
            }
            else
            {
                errorProvider.SetError(txtPhoneNumber, "");
            }
        }

        private void ValidateNationalNumber(object sender, CancelEventArgs e)
        {
            if (!Validation.IsValidNationalNumber(txtNationalNumber.Text.Trim()))
            {
                errorProvider.SetError(txtNationalNumber, "Please enter a valid national number.");
            }
            else
            {
                errorProvider.SetError(txtNationalNumber, "");
            }
        }

        private void IsNationalNoExists(object sender, EventArgs e)
        {
            if (_personService.IsNationalNoExists(txtNationalNumber.Text.Trim()))
            {
                errorProvider.SetError(txtNationalNumber, "This national number already exists.");
            }
            else
            {
                errorProvider.SetError(txtNationalNumber, "");
            }
        }

        private void ValidateEmail(object sender, EventArgs e)
        {
            if (!Validation.IsValidEmail(txtEmail.Text.Trim()) && txtEmail.Text.Trim() != "")
            {
                errorProvider.SetError(txtEmail, "Please enter a valid email address.");
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }
        }

    }
}
