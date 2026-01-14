using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Clinic_Appointment_System_Data_Access_Layer
{
    public class PersonData
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ClinicAppointment"].ConnectionString;

        public static bool IsNationalNoExists(string nationalNo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsNationalNoExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", nationalNo);
                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        return Convert.ToBoolean(result);
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}
