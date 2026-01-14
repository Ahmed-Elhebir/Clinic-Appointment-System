using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.Payment;
using Clinic_Appointment_System_Global.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Business_Layer
{
    public class PaymentService
    {
        public int PaymentID { get; set; }
        public int AppointmentID { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public int UserID { get; set; }

        public PaymentDTO PayDTO
        {
            get { return new PaymentDTO(this.PaymentID, this.AppointmentID, this.Amount, this.PaymentMethod, this.PaymentDate, this.UserID); }
        }

        public PaymentService()
        {
            PaymentID = -1;
            AppointmentID = -1;
            Amount = 0;
            PaymentMethod = PaymentMethodEnum.Cash;
            UserID = -1;
        }

        public static OperationResult IsPaid(int appointmentID)
        {
            PaymentData.IsPaid(appointmentID, out bool paid);
            if (paid)
                return OperationResult.SuccessResult("Appointment is already paid.", paid);
            else
                return OperationResult.FailureResult("Appointment is not paid yet.");
        }

        private OperationResult _AddNewPayment()
        {
            PaymentData.AddNewAppointmentPayment(PayDTO, out int newPaymentID);

            if (newPaymentID != -1)
            {
                this.PaymentID = newPaymentID;
                return OperationResult.SuccessResult("Payment added successfully.", newPaymentID);
            }
            else
            {
                return OperationResult.FailureResult("Failed to add payment.");
            }
        }

        public OperationResult Save()
        {
            return _AddNewPayment();
        }

    }
}
