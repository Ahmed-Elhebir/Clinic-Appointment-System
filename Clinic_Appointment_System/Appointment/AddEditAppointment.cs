using Clinic_Appointment_System.UserControls;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.Specialty;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic_Appointment_System.Appointment
{
    public partial class AddEditAppointment : Form
    {
        private enum enMode { AddNew, Update }
        private enMode _Mode = enMode.AddNew;

        private int _selectedPatientID = -1;
        private int _selectedDoctorID = -1;
        DoctorService doctor = null;
        PatientService patient = null;
        private int _AppointmentID = -1;

        private AppointmentService _AppointmentService = new AppointmentService();

        public AddEditAppointment()
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
            pbClose.BackColor = ThemeColors.MainBackground;

            lblAddEditTitle.ForeColor = ThemeColors.MainLabelText;
            lblPatientSearch.ForeColor = ThemeColors.MainLabelText;
            lblDoctorSearch.ForeColor = ThemeColors.MainLabelText;
            lblAppointmentDatePicker.ForeColor = ThemeColors.MainLabelText;
            lblTimePicker.ForeColor = ThemeColors.MainLabelText;
            lblNotes.ForeColor = ThemeColors.MainLabelText;

            btnSave.BackColor = ThemeColors.SaveButtonBackColor;
            btnSave.ForeColor = ThemeColors.SaveButtonForeColor;
            btnCancel.BackColor = ThemeColors.CancelButtonBackColor;
            btnCancel.ForeColor = ThemeColors.CancelButtonForeColor;
        }

        private void SetIcons()
        {
            pbClose.Image = ThemeColors.CloseIcon;
            btnSave.Image = ThemeColors.SaveIcon;
            btnCancel.Image = ThemeColors.CancelIcon;
        }

        public AddEditAppointment(int appointmentID)
        {
            InitializeComponent();
            _AppointmentID = appointmentID;
            _Mode = enMode.Update;
            FormDragHelper.EnableDrag(this.pFullForm);
            UC_Settings.OnSettingsChanged += ThemeChanged;
        }

        private void SearchPatient_OnSearch(object sender, SearchControl.SearchEventArgs e)
        {
            switch (e.FilterBy)
            {
                case "Patient ID":
                    patient = PatientService.FindByID(int.Parse(e.SearchText));
                    break;
                case "File Number":
                    patient = PatientService.FindByFileNo(e.SearchText);
                    break;
                case "National Number":
                    patient = PatientService.FindByNationalNo(e.SearchText);
                    break;
            }

            if (patient == null)
            {
                _selectedPatientID = -1;
                if (MessageBox.Show("No patient found with the given information.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    return;
            }

            _selectedPatientID = patient.PatientID;
            searchPatient.DisplayResult(
                $"Patient's Name: {patient.PaDTO.PersonDTO.FullName}",
                $"File No: {patient.FileNo}"
            );
        }

        private string _DisplayTime(short hours, short minutes)
        {
            if (hours == 0)
            {
                return $"12:{minutes:00} AM";
            }
            else if (hours >= 12)
            {
                short newHour = (short)((hours == 12) ? 12 : (hours - 12));
                return $"{newHour}:{minutes:00} PM";
            }

            return $"{hours}:{minutes:00} AM";

        }
        // 24 hour format
        private List<string> _BusinessTimeData(short startingHours, short endingHours)
        {
            List<String> timeData = new List<String>();

            short timeSlots = (short)(((endingHours - startingHours + 24) % 24) * 2);

            for (short slot = 0; slot < timeSlots; slot++)
            {
                int totalMinutes = slot * 30;
                short hoursToAdd = (short)(totalMinutes / 60);
                short extraMinutes = (short)(totalMinutes % 60);
                short newHour = (short)((startingHours + hoursToAdd) % 24);

                timeData.Add(_DisplayTime(newHour, extraMinutes));
            }
            return timeData;
        }

        private void _ResetValues()
        {
            // Using 24 hour format
            short startingShiftTime = 14;
            short endingShiftTime = 22;

            var patientFilter = new List<string>
            {
                "Patient ID",
                "File Number",
                "National Number"
            };

            var doctorFilter = new List<string>
            {
                "Doctor ID",
                "National Number"
            };

            searchPatient.SetFilterOptions(patientFilter);
            searchDoctor.SetFilterOptions(doctorFilter);

            if (startingShiftTime < 0 || startingShiftTime > 23 || endingShiftTime < 0 || endingShiftTime > 23)
            {
                MessageBox.Show("Invalid shift configuration!");
                return;
            }

            cbBusinessTime.DataSource = _BusinessTimeData(startingShiftTime, endingShiftTime);

            txtNotes.Text = "";
        }

        private void _LoadData()
        {
            _AppointmentService = AppointmentService.FindByID(_AppointmentID);

            if (_AppointmentService == null)
            {
                MessageBox.Show($"No Appointment found with this ID [{_AppointmentID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectedPatientID = _AppointmentService.PatientID;
            _selectedDoctorID = _AppointmentService.DoctorID;

            patient = PatientService.FindByID(_selectedPatientID);
            doctor = DoctorService.FindByID(_selectedDoctorID);
            SpecialtyDTO specialty = SpecialtyService.FindByID(doctor.SpecialtyID);

            if (patient == null)
            {
                MessageBox.Show("Patient is no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (doctor == null)
            {
                MessageBox.Show("Doctor is no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (specialty == null)
            {
                MessageBox.Show("Doctor's specialty not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            searchPatient.DisplayResult(
                $"Patient's Name: {patient.PaDTO.PersonDTO.FullName}",
                $"File No: {patient.FileNo}"
            );
            searchPatient.DisableControl();

            searchDoctor.DisplayResult(
                $"Doctor's Name: {doctor.DrDTO.PersonDTO.FullName}",
                $"Specialty: {specialty.SpecialtyName}"
            );
            searchDoctor.DisableControl();

            dtpAppointmentDate.Value = _AppointmentService.AppointmentDate;
            dtpAppointmentDate.Enabled = false;

            string timeToFind = _DisplayTime(
                        Convert.ToInt16(_AppointmentService.AppointmentDate.Hour), 
                        Convert.ToInt16(_AppointmentService.AppointmentDate.Minute)
                        );
            int index = cbBusinessTime.FindStringExact(timeToFind);

            if (index >= 0)
                cbBusinessTime.SelectedIndex = index;
            cbBusinessTime.Enabled = false;

            txtNotes.Text = _AppointmentService.AppointmentNotes;
        }

        private void AddEditAppointment_Load(object sender, EventArgs e)
        {
            _ResetValues();
            ApplyTheme();

            if (_Mode == enMode.Update)
                _LoadData();
        }
        
        private void SearchDoctor_OnSearch(object sender, SearchControl.SearchEventArgs e)
        {
            switch (e.FilterBy)
            {
                case "Doctor ID":
                    doctor = DoctorService.FindByID(int.Parse(e.SearchText));
                    break;
                case "National Number":
                    doctor = DoctorService.FindByNationalNo(e.SearchText);
                    break;
            }

            if (doctor == null)
            {
                _selectedDoctorID = -1;
                if (MessageBox.Show("No doctor found with the given information.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    this.Close();
                return;
            }

            _selectedDoctorID = doctor.DoctorID;
            
            SpecialtyDTO specialty = SpecialtyService.FindByID(doctor.SpecialtyID);
            if (specialty == null)
            {
                if (MessageBox.Show("Doctor's specialty not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    this.Close();
                return;
            }

            searchDoctor.DisplayResult(
                $"Doctor's Name: {doctor.DrDTO.PersonDTO.FullName}",
                $"Specialty: {specialty.SpecialtyName}"
            );

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fill all required fields with valid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedPatientID == -1 || _selectedDoctorID == -1)
            {
                MessageBox.Show("Please select both patient and doctor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _AppointmentService.PatientID = _selectedPatientID;
            _AppointmentService.DoctorID = _selectedDoctorID;

            var appointmentDate = dtpAppointmentDate.Value.Date + Convert.ToDateTime(cbBusinessTime.SelectedItem).TimeOfDay;

            _AppointmentService.AppointmentDate = appointmentDate;
            _AppointmentService.AppointmentNotes = txtNotes.Text.Trim();
            _AppointmentService.UserID = CurrentUser.UserID;

            var result = _AppointmentService.Save();

            if (result.Success)
            {
                if (MessageBox.Show($"{result.Message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Close();
            }
            else
            {
                MessageBox.Show($"{result.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchPatient_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_selectedPatientID == -1)
            {
                errorProvider.SetError(searchPatient, "Please select a patient.");
            }
            else
            {
                errorProvider.SetError(searchPatient, "");
            }
        }

        private void searchDoctor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_selectedDoctorID == -1)
            {
                errorProvider.SetError(searchDoctor, "Please select a doctor.");
            }
            else
            {
                errorProvider.SetError(searchDoctor, "");
            }
        }

        private void dtpAppointmentDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dtpAppointmentDate.Value.Date < DateTime.Now.Date && _Mode == enMode.AddNew)
            {
                errorProvider.SetError(dtpAppointmentDate, "Appointment date cannot be in the past.");
            }
            else
            {
                errorProvider.SetError(dtpAppointmentDate, "");
            }
        }

        private void cbBusinessTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var businessTime = Convert.ToDateTime(cbBusinessTime.SelectedItem).TimeOfDay;
            if (businessTime < DateTime.Now.TimeOfDay && dtpAppointmentDate.Value.Date <= DateTime.Now && _Mode == enMode.AddNew)
            {
                errorProvider.SetError(cbBusinessTime, "Appointment time cannot be in the past.");
            }
            else
            {
                errorProvider.SetError(cbBusinessTime, "");
            }
        }


    }
}
