using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs;
using Clinic_Appointment_System_Global.DTOs.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Business_Layer
{
    public class DoctorService
    {
        public enum enDoctorOperationResult
        {
            Success = 1,
            UnexpectedError = -1
        }
        public enum enMode { AddNew, Update }
        public enMode _Mode;
        public PersonDTO _PersonDTO;

        public DoctorDTO DrDTO
        {
            get { return new DoctorDTO(this.DoctorID, this.SpecialtyID, this.PersonID, this._PersonDTO); }
        }

        public int DoctorID { get; set; }
        public int PersonID { get; set; }
        public int SpecialtyID { get; set; }

        public DoctorService()
        {
            this.DoctorID = -1;
            this.SpecialtyID = -1;
            this._PersonDTO = new PersonDTO(-1, "", "", "", "", "", GenderEnum.Male, "", "", DateTime.Now, -1);

            this._Mode = enMode.AddNew;
        }

        public DoctorService(DoctorDTO DaDTO, enMode cMode = enMode.AddNew)
        {
            this.DoctorID = DaDTO.DoctorID;
            this.SpecialtyID = DaDTO.SpecialtyID;
            this.PersonID = DaDTO.PersonId;
            this._PersonDTO = DaDTO.PersonDTO;

            this._Mode = cMode;
        }

        public static List<DoctorListDTO> GetAllDoctors()
        {
            return DoctorData.GetAllDoctors();
        }

        public static DoctorService FindByID(int doctorID)
        {
            DoctorDTO doctorDTO = DoctorData.GetDoctorByID(doctorID);
            if (doctorDTO != null)
                return new DoctorService(doctorDTO, enMode.Update);
            else
                return null;
        }

        public static string GetDoctorFullNameByID(int doctorID)
        {
            return FindByID(doctorID).DrDTO?.PersonDTO.FullName ?? "";
        }

        public static DoctorService FindByNationalNo(string nationalNo)
        {
            DoctorDTO doctorDTO = DoctorData.GetDoctorByNationalNo(nationalNo);
            if (doctorDTO != null)
                return new DoctorService(doctorDTO, enMode.Update);
            else
                return null;
        }

        public OperationResult Delete(int doctorID)
        {
            bool result = DoctorData.DeleteDoctor(doctorID);
            if (result)
                return OperationResult.SuccessResult("Doctor deleted successfully.");
            else
                return OperationResult.FailureResult("Failed to delete doctor due to a database error.");
        }

        private OperationResult _AddNewDoctor()
        {
            enDoctorOperationResult result = (enDoctorOperationResult)DoctorData.AddDoctor(DrDTO, out int newDoctorID);
            switch(result)
            {
                case enDoctorOperationResult.Success:
                    this.DoctorID = newDoctorID;
                    return OperationResult.SuccessResult("Doctor added successfully.", newDoctorID);
                case enDoctorOperationResult.UnexpectedError:
                default:
                    return OperationResult.FailureResult("An unknown error occurred while adding the doctor.");
            }
        }
        
        private OperationResult _UpdateDoctor()
        {
            bool result = DoctorData.UpdateDoctor(DrDTO);
            if (result)
                return OperationResult.SuccessResult("Doctor updated successfully.");
            else
                return OperationResult.FailureResult("Failed to update appointment due to a database error.");
        }

        public OperationResult Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    OperationResult result = _AddNewDoctor();
                    if (result.Success)                    
                        _Mode = enMode.Update;
                    return result;
                    
                case enMode.Update:
                    return _UpdateDoctor();
                default:
                    return OperationResult.FailureResult("Invalid operation mode.");
            }
        }

    }
}
