using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Appointment_System_Global.Enums;

namespace Clinic_Appointment_System_Global.DTOs.Appointment
{
    public class AppointmentUpdateDTO
    {
        public int AppointmentID { get; set; }
        public AppointmentStatusEnum AppointmentStatus { get; set; }
        public string AppointmentNotes { get; set; }
        public int UserID { get; set; }

        public AppointmentUpdateDTO(int appointmentID , AppointmentStatusEnum appointmentStatus, 
            string appointmentNotes, int userID)
        {
            AppointmentID = appointmentID;
            AppointmentStatus = appointmentStatus;
            AppointmentNotes = appointmentNotes;
            UserID = userID;
        }
    }
}
