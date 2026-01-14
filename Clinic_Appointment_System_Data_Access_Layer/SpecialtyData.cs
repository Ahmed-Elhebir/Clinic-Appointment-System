using Clinic_Appointment_System_Global.DTOs.Specialty;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Clinic_Appointment_System_Data_Access_Layer
{
    public class SpecialtyData
    {
        private readonly static string _connectionString = ConfigurationManager.ConnectionStrings["ClinicAppointment"].ConnectionString;

        public static List<SpecialtyDTO> GetAllSpecialties()
        {
            List<SpecialtyDTO> specialties = new List<SpecialtyDTO>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllSpecialties", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                specialties.Add(new SpecialtyDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("SpecialtyID")),
                                    reader.GetString(reader.GetOrdinal("SpecialtyName"))
                                ));
                            }
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            return specialties;
        }

        public static SpecialtyDTO GetSpecialtyByID(int specialtyID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetSpecialtyByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SpecialtyID", specialtyID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new SpecialtyDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("SpecialtyID")),
                                    reader.GetString(reader.GetOrdinal("SpecialtyName"))
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

        public static SpecialtyDTO GetSpecialtyByName(string specialtyName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetSpecialtyByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SpecialtyName", specialtyName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new SpecialtyDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("SpecialtyID")),
                                    reader.GetString(reader.GetOrdinal("SpecialtyName"))
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
