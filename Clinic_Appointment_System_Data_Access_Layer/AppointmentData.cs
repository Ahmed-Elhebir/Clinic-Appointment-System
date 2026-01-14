using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.Appointment;
using Clinic_Appointment_System_Global.Enums;

namespace Clinic_Appointment_System_Data_Access_Layer
{
    public class AppointmentData
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ClinicAppointment"].ConnectionString;

        // Add Appointment
        public static int AddAppointment(AppointmentCreateDTO appointmenCreateDTO, out int newAppointmentID)
        {
            DateTime currentDateTime = DateTime.Now;
            int defaultStatus = (int)AppointmentStatusEnum.Scheduled;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // Insert into Appointment table
                using (SqlCommand command = new SqlCommand("SP_AddAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PatientID", appointmenCreateDTO.PatientID);
                    command.Parameters.AddWithValue("@DoctorID", appointmenCreateDTO.DoctorID);
                    command.Parameters.AddWithValue("@AppointmentDate", appointmenCreateDTO.AppointmentDate);
                    command.Parameters.AddWithValue("@AppointmentStatusID", defaultStatus);
                    command.Parameters.AddWithValue("@AppointmentNotes", appointmenCreateDTO.AppointmentNotes);
                    command.Parameters.AddWithValue("@UpdateAt", currentDateTime);
                    command.Parameters.AddWithValue("@CreatedAt", currentDateTime);
                    command.Parameters.AddWithValue("@CreatedByUserID", appointmenCreateDTO.UserID);


                    var outputIdParam = new SqlParameter("@NewAppointmentID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    var returnParam = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    }; 

                    command.Parameters.Add(outputIdParam);
                    command.Parameters.Add(returnParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        int returnCode = Convert.ToInt32(returnParam.Value);
                        newAppointmentID = (outputIdParam.Value != DBNull.Value) ? Convert.ToInt32(outputIdParam.Value) : -1;
                        return returnCode;
                    }
                    catch 
                    {
                        newAppointmentID = -1;
                        return -1;
                    }
                }
            }
        }
        // Get All Appointments
        public static AppointmentsDataResult GetAllAppointments()
        {
            AppointmentsDataResult result = new AppointmentsDataResult(new List<AppointmentListDTO>(), -1, -1);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllAppointments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    var todaysCountParam = new SqlParameter("@TodaysCount", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    var completedCountParam = new SqlParameter("@CompletedCount", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(todaysCountParam);
                    command.Parameters.Add(completedCountParam);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Appointments.Add(new AppointmentListDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("AppointmentID")),
                                    reader.GetString(reader.GetOrdinal("PatientName")),
                                    reader.GetString(reader.GetOrdinal("DoctorName")),
                                    reader.GetDateTime(reader.GetOrdinal("AppointmentDate")),
                                    reader.GetString(reader.GetOrdinal("StatusName")),
                                    reader.GetDateTime(reader.GetOrdinal("UpdateAt")),
                                    reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                                ));
                            }
                        }
                    }
                    catch
                    {
                        return null;
                    }
                    result.TodaysCount = (todaysCountParam.Value != DBNull.Value) ? Convert.ToInt32(todaysCountParam.Value) : 0;
                    result.CompletedCount = (completedCountParam.Value != DBNull.Value) ? Convert.ToInt32(completedCountParam.Value) : 0;
                }
            }
            return result;
        }
        // Get Appointment By ID
        public static AppointmentDTO GetAppointmentByID(int appointmentID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAppointmentByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new AppointmentDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("AppointmentID")),
                                    reader.GetInt32(reader.GetOrdinal("PatientID")),
                                    reader.GetInt32(reader.GetOrdinal("DoctorID")),
                                    reader.GetDateTime(reader.GetOrdinal("AppointmentDate")),
                                    (AppointmentStatusEnum)reader.GetInt32(reader.GetOrdinal("AppointmentStatusID")),
                                    reader.GetString(reader.GetOrdinal("AppointmentNotes")),
                                    reader.GetDateTime(reader.GetOrdinal("UpdateAt")),
                                    reader.GetDateTime(reader.GetOrdinal("CreatedAt")),
                                    reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                );
                            }
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        // Update Appointment
        public static bool UpdateAppointment(AppointmentUpdateDTO appointmentUpdateDTO)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // Update Appointment table 
                using (SqlCommand command = new SqlCommand("SP_UpdateAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AppointmentStatusID", appointmentUpdateDTO.AppointmentStatus);
                    command.Parameters.AddWithValue("@AppointmentNotes", appointmentUpdateDTO.AppointmentNotes);
                    command.Parameters.AddWithValue("@UserID", appointmentUpdateDTO.UserID);
                    command.Parameters.AddWithValue("@AppointmentID", appointmentUpdateDTO.AppointmentID);
                    
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // Appointment Daily Report
        public static AppointmentReportDataResult GetAppointmentDailyReport(DateTime reportDate)
        {
            AppointmentReportDataResult report = new AppointmentReportDataResult(new List<AppointmentDailyReportDTO>(), -1, -1, -1);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // Delete from Appointment table;
                using (SqlCommand command = new SqlCommand("SP_GetDailyReport", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ReportDate", reportDate);

                    var todayCountParam = new SqlParameter("@TodaysCount", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    var completedCountParam = new SqlParameter("@CompletedCount", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    var cancelledCountParam = new SqlParameter("@CancelledCount", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(todayCountParam);
                    command.Parameters.Add(completedCountParam);
                    command.Parameters.Add(cancelledCountParam);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                report.ReportData.Add(new AppointmentDailyReportDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("AppointmentID")),
                                    reader.GetString(reader.GetOrdinal("PatientName")),
                                    reader.GetString(reader.GetOrdinal("DoctorName")),
                                    reader.GetDateTime(reader.GetOrdinal("AppointmentDate")),
                                    reader.GetString(reader.GetOrdinal("StatusName")),
                                    reader.GetString(reader.GetOrdinal("UserName"))
                                ));
                            }
                        }

                    }
                    catch
                    {
                        return null;
                    }
                    report.CountScheduled = (todayCountParam.Value != DBNull.Value) ? Convert.ToInt32(todayCountParam.Value) : 0;
                    report.CountCompleted = (completedCountParam.Value != DBNull.Value) ? Convert.ToInt32(completedCountParam.Value) : 0;
                    report.CountCancelled = (cancelledCountParam.Value != DBNull.Value) ? Convert.ToInt32(cancelledCountParam.Value) : 0;

                }
            }
            return report;
        }
        
    }
}
