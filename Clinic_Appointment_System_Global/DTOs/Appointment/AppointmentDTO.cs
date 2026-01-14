using Clinic_Appointment_System_Global.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Global.DTOs.Appointment
{
    public class AppointmentDTO
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public AppointmentStatusEnum AppointmentStatus { get; set; }
        public string AppointmentNotes { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserID { get; set; }


        public AppointmentDTO(int appointmentID, int patientID, int doctorID, DateTime appointmentDate,
            AppointmentStatusEnum appointmentStatus, string appointmentNotes, DateTime updateAt,
            DateTime createdAt, int userID)
        {
            AppointmentID = appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            AppointmentDate = appointmentDate;
            AppointmentStatus = appointmentStatus;
            AppointmentNotes = appointmentNotes;
            UpdateAt = updateAt;
            CreatedAt = createdAt;
            UserID = userID;
        }
    }
}
