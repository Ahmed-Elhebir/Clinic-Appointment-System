using Clinic_Appointment_System_Global.DTOs.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Global
{
    public class AppointmentReportDataResult
    {
        public List<AppointmentDailyReportDTO> ReportData { get; set; }
        public int CountScheduled { get; set; }
        public int CountCompleted { get; set; }
        public int CountCancelled { get; set; }

        public AppointmentReportDataResult(List<AppointmentDailyReportDTO> reportData,
            int countScheduled, int countCompleted, int countCancelled)
        {
            ReportData = reportData;
            CountScheduled = countScheduled;
            CountCompleted = countCompleted;
            CountCancelled = countCancelled;
        }
    }
}
