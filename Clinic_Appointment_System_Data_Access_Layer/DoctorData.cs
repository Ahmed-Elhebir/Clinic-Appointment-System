using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs;
using Clinic_Appointment_System_Global.DTOs.Doctor;
using Clinic_Appointment_System_Global.DTOs.Patient;

namespace Clinic_Appointment_System_Data_Access_Layer
{
    public class DoctorData
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ClinicAppointment"].ConnectionString;

        // Add Doctor
        public static int AddDoctor(DoctorDTO doctorDTO, out int newDoctorID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", doctorDTO.PersonDTO.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", doctorDTO.PersonDTO.FirstName);
                    command.Parameters.AddWithValue("@SecondName", doctorDTO.PersonDTO.SecondName);
                    command.Parameters.AddWithValue("@LastName", doctorDTO.PersonDTO.LastName);
                    command.Parameters.AddWithValue("@Gender", doctorDTO.PersonDTO.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", doctorDTO.PersonDTO.PhoneNumber);
                    command.Parameters.AddWithValue("@DateOfBirth", doctorDTO.PersonDTO.DateOfBirth);
                    command.Parameters.AddWithValue("@NationalityCountryID", doctorDTO.PersonDTO.NationalityCountryID);
                    command.Parameters.AddWithValue("@SpecialtyID", doctorDTO.SpecialtyID);

                    if (doctorDTO.PersonDTO.ThirdName != "" && doctorDTO.PersonDTO.ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", doctorDTO.PersonDTO.ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

                    if (doctorDTO.PersonDTO.Email != "" && doctorDTO.PersonDTO.Email != null)
                        command.Parameters.AddWithValue("@Email", doctorDTO.PersonDTO.Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    var outputDoctorIdParam = new SqlParameter("@NewDoctorID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputDoctorIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        newDoctorID = (outputDoctorIdParam.Value != DBNull.Value) ? Convert.ToInt32(outputDoctorIdParam.Value) : -1;
                        return 1;
                    }
                    catch
                    {
                        newDoctorID = -1;
                        return -1;
                    }
                }
            }
        }
        // Get Doctor
        public static List<DoctorListDTO> GetAllDoctors()
        {
            List<DoctorListDTO> doctorList = new List<DoctorListDTO>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllDoctors", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                doctorList.Add(new DoctorListDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("DoctorID")),
                                    reader.GetString(reader.GetOrdinal("FullName")),
                                    reader.GetString(reader.GetOrdinal("SpecialtyName")),
                                    reader.GetByte(reader.GetOrdinal("Age")),
                                    reader.GetString(reader.GetOrdinal("Gender")),
                                    reader.GetString(reader.GetOrdinal("CountryName")),
                                    reader.GetString(reader.GetOrdinal("NationalNo"))
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
            return doctorList;
        }
        // Get Doctor By ID
        public static DoctorDTO GetDoctorByID(int doctorID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetDoctorByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DoctorID", doctorID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new DoctorDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("DoctorID")),
                                    reader.GetInt32(reader.GetOrdinal("SpecialtyID")),
                                    reader.GetInt32(reader.GetOrdinal("PersonID")),
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
        // Get Doctor By National No
        public static DoctorDTO GetDoctorByNationalNo(string nationalNo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetDoctorByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new DoctorDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("DoctorID")),
                                    reader.GetInt32(reader.GetOrdinal("SpecialtyID")),
                                    reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    new PersonDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("PersonID")),
                                        reader.GetString(reader.GetOrdinal("NationalNo")),
                                        reader.GetString(reader.GetOrdinal("FirstName")),
                                        reader.GetString(reader.GetOrdinal("SecondName")),
                                        reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? "" : reader.GetString(reader.GetOrdinal("ThirdName")),
                                        reader.GetString(reader.GetOrdinal("LastName")),
                                        (GenderEnum)reader.GetByte(reader.GetOrdinal("Gender")),
                                        reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                        reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString(reader.GetOrdinal("Email")),
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
        // Update Doctor
        public static bool UpdateDoctor(DoctorDTO doctorDTO)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", doctorDTO.PersonDTO.PersonID);
                    command.Parameters.AddWithValue("@DoctorID", doctorDTO.DoctorID);
                    command.Parameters.AddWithValue("@NationalNo", doctorDTO.PersonDTO.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", doctorDTO.PersonDTO.FirstName);
                    command.Parameters.AddWithValue("@SecondName", doctorDTO.PersonDTO.SecondName);
                    command.Parameters.AddWithValue("@LastName", doctorDTO.PersonDTO.LastName);
                    command.Parameters.AddWithValue("@Gender", doctorDTO.PersonDTO.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", doctorDTO.PersonDTO.PhoneNumber);
                    command.Parameters.AddWithValue("@DateOfBirth", doctorDTO.PersonDTO.DateOfBirth);
                    command.Parameters.AddWithValue("@NationalityCountryID", doctorDTO.PersonDTO.NationalityCountryID);
                    command.Parameters.AddWithValue("@SpecialtyID", doctorDTO.SpecialtyID);

                    if (doctorDTO.PersonDTO.Email != "" && doctorDTO.PersonDTO.Email != null)
                        command.Parameters.AddWithValue("@Email", doctorDTO.PersonDTO.Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    if (doctorDTO.PersonDTO.ThirdName != "" && doctorDTO.PersonDTO.ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", doctorDTO.PersonDTO.ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

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
        // Delete Doctor
        public static bool DeleteDoctor(int DoctorID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
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

    }
}
