using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Clinic_Appointment_System.UserControls;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.Country;
using Clinic_Appointment_System_Global.DTOs.Specialty;

namespace Clinic_Appointment_System.Doctor
{
    public partial class AddEditDoctor : Form
    {
        private const string DefaultCountry = "Saudi Arabia";
        private const int DefaultMaxAge = 155;
        private enum enMode { AddNew, Update }

        private enMode _Mode;
        private readonly int _DoctorID;
        DoctorService _doctorService = new DoctorService();
        PersonService _personService = new PersonService();

        public AddEditDoctor()
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
            lblSpecialty.ForeColor = ThemeColors.MainLabelText;

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

        public AddEditDoctor(int doctorID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _DoctorID = doctorID;
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
            _doctorService._PersonDTO.FirstName = txtFirstName.Text.Trim();
            _doctorService._PersonDTO.SecondName = txtSecondName.Text.Trim();
            
            _doctorService._PersonDTO.LastName = txtLastName.Text.Trim();
            _doctorService._PersonDTO.PhoneNumber = txtPhoneNumber.Text.Trim();
            _doctorService._PersonDTO.DateOfBirth = dtDateOfBirth.Value;
            _doctorService._PersonDTO.NationalityCountryID = CountryService.FindByName(cbNationality.Text).CountryID;
            _doctorService.SpecialtyID = SpecialtyService.GetSpecialtyByName(cbSpecialty.Text).SpecialtyID;
            _doctorService._PersonDTO.NationalNo = txtNationalNumber.Text.Trim();

            if (txtThirdName.Text.Trim() == "")
                _doctorService._PersonDTO.ThirdName = null;
            else
                _doctorService._PersonDTO.ThirdName = txtThirdName.Text.Trim();

            if (txtEmail.Text.Trim() == "")
                _doctorService._PersonDTO.Email = null;
            else
                _doctorService._PersonDTO.Email = txtEmail.Text.Trim();

            if (rbMale.Checked)
                _doctorService._PersonDTO.Gender = GenderEnum.Male;
            else
                _doctorService._PersonDTO.Gender = GenderEnum.Female;

            OperationResult result = _doctorService.Save();
            if (result.Success)
            {
                lblAddEditTitle.Text = "Update Doctor";
                this.Text = "Update Doctor";
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

        private void _FillSpecialtyInComboBox()
        {
            cbSpecialty.Items.Clear();
            List<SpecialtyDTO> specialties = SpecialtyService.GetAllSpecialties();
            foreach (var specialty in specialties)
            {
                cbSpecialty.Items.Add(specialty.SpecialtyName);
            }
        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
            _FillSpecialtyInComboBox();

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Doctor";
                lblAddEditTitle.Text = "Add New Doctor";
            }

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";

            dtDateOfBirth.Value = DateTime.Now;
            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-DefaultMaxAge);

            cbNationality.SelectedIndex = cbNationality.FindString(DefaultCountry);
            cbSpecialty.SelectedIndex = 0;

            txtNationalNumber.Text = "";
            txtEmail.Text = "";
            rbMale.Checked = true;
        }
        
        private void _LoadData()
        {
            _doctorService = DoctorService.FindByID(_DoctorID);

            if (_doctorService == null)
            {
                MessageBox.Show("Failed to load doctor data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Text = "Update Doctor";
            lblAddEditTitle.Text = "Update Doctor";

            txtFirstName.Text = _doctorService.DrDTO.PersonDTO.FirstName;
            txtSecondName.Text = _doctorService.DrDTO.PersonDTO.SecondName;
            txtThirdName.Text = _doctorService.DrDTO.PersonDTO.ThirdName;
            txtLastName.Text = _doctorService.DrDTO.PersonDTO.LastName;
            txtPhoneNumber.Text = _doctorService.DrDTO.PersonDTO.PhoneNumber;
            dtDateOfBirth.Value = _doctorService.DrDTO.PersonDTO.DateOfBirth;
            cbNationality.SelectedIndex = cbNationality.FindString(CountryService.FindByID(_doctorService.DrDTO.PersonDTO.NationalityCountryID).CountryName);
            txtNationalNumber.Text = _doctorService.DrDTO.PersonDTO.NationalNo;
            txtEmail.Text = _doctorService.DrDTO.PersonDTO.Email;
            if (_doctorService.DrDTO.PersonDTO.Gender == GenderEnum.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

        }

        private void AddEditDoctor_Load(object sender, EventArgs e)
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
