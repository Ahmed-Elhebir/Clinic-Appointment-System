using System;
using Clinic_Appointment_System_Global.Enums;

namespace Clinic_Appointment_System_Global.DTOs.Appointment
{
    public class AppointmentListDTO
    {
        public int AppointmentID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string StatusName { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CreatedAt { get; set; }


        public AppointmentListDTO(int appointmentID, string patientName, string doctorName,
            DateTime appointmentDate, string statusName,
            DateTime updateAt, DateTime createdAt)
        {
            AppointmentID = appointmentID;
            PatientName = patientName;
            DoctorName = doctorName;
            AppointmentDate = appointmentDate;
            StatusName = statusName;
            CreatedAt = createdAt;
            UpdateAt = updateAt;
        }
    }
}
