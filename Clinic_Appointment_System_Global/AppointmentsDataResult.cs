using Clinic_Appointment_System_Global.DTOs.Appointment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Global
{
    public class AppointmentsDataResult
    {
        public List<AppointmentListDTO> Appointments { get; set; }
        public int TodaysCount { get; set; }
        public int CompletedCount { get; set; }

        public AppointmentsDataResult(List<AppointmentListDTO> appointments, int todaysCount, int completedCount)
        {
            Appointments = appointments;
            TodaysCount = todaysCount;
            CompletedCount = completedCount;
        }
    }
}
