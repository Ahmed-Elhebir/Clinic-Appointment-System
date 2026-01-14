using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs;
using Clinic_Appointment_System_Global.DTOs.User;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Clinic_Appointment_System_Data_Access_Layer
{
    public class UserData
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ClinicAppointment"].ConnectionString;

        public static UserDTO GetUserByUserNameAndPassword(string userName, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByUserNameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {
                                return new UserDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("UserID")),
                                    reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    reader.GetString(reader.GetOrdinal("UserName")),
                                    reader.GetString(reader.GetOrdinal("Password")),
                                    reader.GetString(reader.GetOrdinal("Role")),
                                    reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    new PersonDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("PersonID")),
                                        reader.GetString(reader.GetOrdinal("NationalNo")),
                                        reader.GetString(reader.GetOrdinal("FirstName")),
                                        reader.GetString(reader.GetOrdinal("SecondName")),
                                        reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? null : reader.GetString(reader.GetOrdinal("ThirdName")),
                                        reader.GetString(reader.GetOrdinal("LastName")),
                                        (GenderEnum)reader.GetByte(reader.GetOrdinal("Gender")),
                                        reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                        reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                                        reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                        reader.GetInt32(reader.GetOrdinal("NationalityCountryID"))
                                    )
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


    }
}
