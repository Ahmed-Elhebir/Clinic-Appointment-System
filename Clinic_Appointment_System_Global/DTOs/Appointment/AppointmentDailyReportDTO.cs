using System;

namespace Clinic_Appointment_System_Global.DTOs.Appointment
{
    public class AppointmentDailyReportDTO
    {
        public int AppointmentID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string StatusName { get; set; }
        public string UserName { get; set; }

        public AppointmentDailyReportDTO(int appointmentID, string patientName, string doctorName,
            DateTime appointmentDate, string statusName, string userName)
        {
            AppointmentID = appointmentID;
            PatientName = patientName;
            DoctorName = doctorName;
            AppointmentDate = appointmentDate;
            StatusName = statusName;
            UserName = userName;
        }
    }
}
