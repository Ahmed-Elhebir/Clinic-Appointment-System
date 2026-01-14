using Clinic_Appointment_System_Global.DTOs.Payment;
using Clinic_Appointment_System_Global.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Data_Access_Layer
{
    public class PaymentData
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ClinicAppointment"].ConnectionString;

        public static void AddNewAppointmentPayment(PaymentDTO paymentDTO, out int newPaymentID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AppointmentID", paymentDTO.AppointmentID);
                    command.Parameters.AddWithValue("@Amount", paymentDTO.Amount);
                    command.Parameters.AddWithValue("@PaymentMethodID", Convert.ToInt32(paymentDTO.PaymentMethod));
                    command.Parameters.AddWithValue("@PaymentDate", paymentDTO.PaymentDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", paymentDTO.CreatedByUserID);
                    
                    var outputIdParam = new SqlParameter("@NewPaymentID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        newPaymentID = (int)outputIdParam.Value;
                    }
                    catch
                    {
                        newPaymentID = -1;
                    }
                }
            }
        }

        public static void IsPaid(int appointmentID, out bool paid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsAppointmentPaid", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    var outputPaidParam = new SqlParameter("@IsPaid", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputPaidParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteScalar();
                        paid = Convert.ToBoolean(outputPaidParam.Value);
                    }
                    catch
                    {
                        paid = false;
                    }
                }
            }
        }

    }
}
