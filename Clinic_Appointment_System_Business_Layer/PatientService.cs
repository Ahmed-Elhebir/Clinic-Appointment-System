using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs;
using Clinic_Appointment_System_Global.DTOs.Patient;


namespace Clinic_Appointment_System_Business_Layer
{
    public class PatientService
    {
        public enum enPatientOperationResult
        {
            Success = 1,
            UnexpectedError = -1
        }
        public enum enMode { AddNew, Update }
        public enMode _Mode;
        public PersonDTO _PersonDTO;

        public PatientDTO PaDTO
        {
            get { return new PatientDTO(this.PatientID, this.FileNo, this.PatientID, this._PersonDTO); }
        }

        public int PatientID { get; set; }
        public string FileNo { get; set; }
        public int PersonID { get; set; }

        public PatientService()
        {
            this.PatientID = -1;
            this.FileNo = "";
            this._PersonDTO = new PersonDTO(-1, "", "", "", "", "", GenderEnum.Male, "", "", DateTime.Now, -1);

            this._Mode = enMode.AddNew;
        }

        public PatientService(PatientDTO PaDTO, enMode cMode = enMode.AddNew)
        {
            this.PatientID = PaDTO.PatientID;
            this.FileNo = PaDTO.FileNo;
            this.PersonID = PaDTO.PersonDTO.PersonID;
            this._PersonDTO = PaDTO.PersonDTO;

            this._Mode = cMode;
        }

        public static List<PatientListDTO> GetAllPatients()
        {
            return PatientData.GetAllPatients();
        }

        public static PatientService FindByID(int patientID)
        {
            PatientDTO patientDTO = PatientData.GetPatientById(patientID);
            if (patientDTO != null)
                return new PatientService(patientDTO, enMode.Update);
            else
                return null;
        }

        public static string GetPatientFullNameByID(int patientID)
        {
            return FindByID(patientID).PaDTO?.PersonDTO.FullName ?? "";
        }

        public static PatientService FindByFileNo(string fileNo)
        {
            PatientDTO patientDTO = PatientData.GetPatientByFileNo(fileNo);
            if (patientDTO != null)
                return new PatientService(patientDTO, enMode.Update);
            else
                return null;
        }

        public static PatientService FindByNationalNo(string nationalNo)
        {
            PatientDTO patientDTO = PatientData.GetPatientByNationalNo(nationalNo);
            if (patientDTO != null)
                return new PatientService(patientDTO, enMode.Update);
            else
                return null;
        }

        public OperationResult Delete(int patientID)
        {
            bool result = PatientData.DeletePatient(patientID);
            if (result)
                return OperationResult.SuccessResult("Patient deleted successfully.");
            else
                return OperationResult.FailureResult("Failed to delete patient due to a database error.");
        }

        private OperationResult _AddNewPatient()
        {
            enPatientOperationResult result = (enPatientOperationResult)PatientData.AddPatient(PaDTO, out int newPatientID);
            switch(result)
            {
                case enPatientOperationResult.Success:
                    this.PatientID = newPatientID;
                    return OperationResult.SuccessResult("Patient added successfully.", newPatientID);
                case enPatientOperationResult.UnexpectedError:
                default:
                    return OperationResult.FailureResult("Failed to add patient due to a database error.");
            }
        }

        private OperationResult _UpdatePatient()
        {
            bool result = PatientData.UpdatePatient(_PersonDTO);
            if (result)
                return OperationResult.SuccessResult("Patient updated successfully.");
            else
                return OperationResult.FailureResult("Failed to update patient due to a database error.");
        }

        public OperationResult Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                {
                    OperationResult result = _AddNewPatient();
                    if (result.Success)
                        _Mode = enMode.Update;
                    return result;
                }
                case enMode.Update:
                    return _UpdatePatient();
                default:
                    return OperationResult.FailureResult("Invalid operation mode.");
            }
        }
    }
}
