using Clinic_Appointment_System_Global.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Global.DTOs.Payment
{
    public class PaymentDTO
    {
        public int PaymentID { get; set; }
        public int AppointmentID { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CreatedByUserID { get; set; }


        public PaymentDTO(int paymentID, int appointmentID, decimal amount,
            PaymentMethodEnum paymentMethod, DateTime paymentDate, int createdByUserID)
        {
            PaymentID = paymentID;
            AppointmentID = appointmentID;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
            CreatedByUserID = createdByUserID;
        }
    }
}
