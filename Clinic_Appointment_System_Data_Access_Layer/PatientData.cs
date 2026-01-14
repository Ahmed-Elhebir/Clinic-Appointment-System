using System.Collections.Generic;
using System.Configuration;
using Clinic_Appointment_System_Global.DTOs.Patient;
using Clinic_Appointment_System_Global.DTOs;
using System.Data.SqlClient;
using System.Data;
using System;
using Clinic_Appointment_System_Global;

namespace Clinic_Appointment_System_Data_Access_Layer
{
    public class PatientData
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ClinicAppointment"].ConnectionString;

        // Add Patient
        public static int AddPatient(PatientDTO patientDTO, out int newPatientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", patientDTO.PersonDTO.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", patientDTO.PersonDTO.FirstName);
                    command.Parameters.AddWithValue("@SecondName", patientDTO.PersonDTO.SecondName);
                    command.Parameters.AddWithValue("@LastName", patientDTO.PersonDTO.LastName);
                    command.Parameters.AddWithValue("@Gender", patientDTO.PersonDTO.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", patientDTO.PersonDTO.PhoneNumber);
                    command.Parameters.AddWithValue("@DateOfBirth", patientDTO.PersonDTO.DateOfBirth);
                    command.Parameters.AddWithValue("@NationalityCountryID", patientDTO.PersonDTO.NationalityCountryID);

                    if (patientDTO.PersonDTO.ThirdName != "" && patientDTO.PersonDTO.ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", patientDTO.PersonDTO.ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

                    if (patientDTO.PersonDTO.Email != "" && patientDTO.PersonDTO.Email != null)
                        command.Parameters.AddWithValue("@Email", patientDTO.PersonDTO.Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    var outputPersonIdParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    var outputPatientIdParam = new SqlParameter("@NewPatientID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    var outputFileNoParam = new SqlParameter("@NewFileNo", SqlDbType.NVarChar, 15)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputPersonIdParam);
                    command.Parameters.Add(outputPatientIdParam);
                    command.Parameters.Add(outputFileNoParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        patientDTO.PersonDTO.PersonID = (int)outputPersonIdParam.Value;
                        patientDTO.FileNo = outputFileNoParam.Value.ToString();
                        newPatientID = (outputPatientIdParam.Value != DBNull.Value) ? (int)outputPatientIdParam.Value : -1;
                        return 1;
                    }
                    catch
                    {
                        newPatientID = -1;
                        return -1;
                    }
                }
            }
        }
        // Get Patient
        public static List<PatientListDTO> GetAllPatients()
        {
            List<PatientListDTO> patientList = new List<PatientListDTO>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPatients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                patientList.Add(new PatientListDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("PatientID")),
                                    reader.GetString(reader.GetOrdinal("FullName")),
                                    reader.GetByte(reader.GetOrdinal("Age")),
                                    reader.GetString(reader.GetOrdinal("FileNo")),
                                    reader.GetString(reader.GetOrdinal("NationalNo")),
                                    reader.GetString(reader.GetOrdinal("Gender")),
                                    reader.GetString(reader.GetOrdinal("CountryName"))
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
            return patientList;
        }
        // Get Patient by ID
        public static PatientDTO GetPatientById(int patientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPatientByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PatientID", patientID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new PatientDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("PatientID")),
                                    reader.GetString(reader.GetOrdinal("FileNo")),
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
        // Get Patient by FileNo
        public static PatientDTO GetPatientByFileNo(string fileNo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPatientByFileNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FileNo", fileNo);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new PatientDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("PatientID")),
                                    reader.GetString(reader.GetOrdinal("FileNo")),
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
        // Get patient by National No
        public static PatientDTO GetPatientByNationalNo(string nationalNo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPatientByNationalNo", connection))
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
                                return new PatientDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("PatientID")),
                                    reader.GetString(reader.GetOrdinal("FileNo")),
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
        // Update Patient
        public static bool UpdatePatient(PersonDTO personDTO)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", personDTO.PersonID);
                    command.Parameters.AddWithValue("@NationalNo", personDTO.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", personDTO.FirstName);
                    command.Parameters.AddWithValue("@SecondName", personDTO.SecondName);
                    command.Parameters.AddWithValue("@LastName", personDTO.LastName);
                    command.Parameters.AddWithValue("@Gender", personDTO.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", personDTO.PhoneNumber);
                    command.Parameters.AddWithValue("@DateOfBirth", personDTO.DateOfBirth);
                    command.Parameters.AddWithValue("@NationalityCountryID", personDTO.NationalityCountryID);

                    if (personDTO.ThirdName != "" && personDTO.ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", personDTO.ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

                    if (personDTO.Email != "" && personDTO.Email != null)
                        command.Parameters.AddWithValue("@Email", personDTO.Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

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
        // Delete Patient
        public static bool DeletePatient(int patientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeletePatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientID", patientID);

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
