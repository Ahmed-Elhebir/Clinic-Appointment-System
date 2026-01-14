using System;

using Clinic_Appointment_System_Global.Enums;

namespace Clinic_Appointment_System_Global.DTOs.Appointment
{
    public class AppointmentCreateDTO
    {
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentNotes { get; set; }
        public int UserID { get; set; }

        public AppointmentCreateDTO(int patientID, int doctorID, DateTime appointmentDate, string appointmentNotes, int userID)
        {
            PatientID = patientID;
            DoctorID = doctorID;
            AppointmentDate = appointmentDate;
            AppointmentNotes = appointmentNotes;
            UserID = userID;
        }


    }
}
