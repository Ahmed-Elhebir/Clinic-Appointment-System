using System;
using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.Appointment;
using Clinic_Appointment_System_Global.Enums;

namespace Clinic_Appointment_System_Business_Layer
{
    public class AppointmentService
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public enum enAddAppointmentResult
        {
            Success = 1,
            UnexpectedError = -1,
            DoctorAlreadyBooked = -2,
            PatientHasActiveAppointment = -3
        }

        public AppointmentCreateDTO ACDTO
        {
            get { return new AppointmentCreateDTO(this.PatientID, this.DoctorID, this.AppointmentDate, this.AppointmentNotes, this.UserID); }
        }
        public AppointmentUpdateDTO AUDTO
        {
            get { return new AppointmentUpdateDTO(this.AppointmentID, this.AppointmentStatus, this.AppointmentNotes, this.UserID); }
        }

        public string PatientFullName
        {
            get { return PatientService.GetPatientFullNameByID(this.PatientID); }
        }

        public string DoctorFullName
        {
            get { return DoctorService.GetDoctorFullNameByID(this.DoctorID); }
        }

        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public AppointmentStatusEnum AppointmentStatus { get; set; }
        public string AppointmentNotes { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserID { get; set; }

        public AppointmentService()
        {
            this.AppointmentID = -1;
            this.PatientID = -1;
            this.DoctorID = -1;
            this.AppointmentDate = DateTime.Now;
            this.AppointmentStatus = AppointmentStatusEnum.Scheduled;
            this.AppointmentNotes = "";
            this.UpdateAt = DateTime.Now;
            this.CreatedAt = DateTime.Now;
            this.UserID = -1;

            Mode = enMode.AddNew;
        }

        private AppointmentService(AppointmentDTO appointmentDTO)
        {
            this.AppointmentID = appointmentDTO.AppointmentID;
            this.PatientID = appointmentDTO.PatientID;
            this.DoctorID = appointmentDTO.DoctorID;
            this.AppointmentDate = appointmentDTO.AppointmentDate;
            this.AppointmentStatus = appointmentDTO.AppointmentStatus;
            this.AppointmentNotes = appointmentDTO.AppointmentNotes;
            this.UpdateAt = appointmentDTO.UpdateAt;
            this.CreatedAt = appointmentDTO.CreatedAt;
            this.UserID = appointmentDTO.UserID;

            Mode = enMode.Update;
        }

        public static AppointmentsDataResult GetAllAppointments()
        {
            return AppointmentData.GetAllAppointments();
        }

        public static AppointmentReportDataResult GetAppointmentReport(DateTime reportDate)
        {
            return AppointmentData.GetAppointmentDailyReport(reportDate);
        }

        public static AppointmentService FindByID(int id)
        {
            AppointmentDTO appointmentDTO = AppointmentData.GetAppointmentByID(id);
            if (appointmentDTO != null)
                return new AppointmentService(appointmentDTO);
            else
                return null;
        }

        private OperationResult _AddNewAppointment()
        {
            enAddAppointmentResult returnedValue = (enAddAppointmentResult)AppointmentData.AddAppointment(ACDTO, out int appointmentID);

            switch (returnedValue)
            {
                case enAddAppointmentResult.Success:
                    this.AppointmentID = appointmentID;
                    return OperationResult.SuccessResult("Appointment added successfully.", appointmentID);
                case enAddAppointmentResult.DoctorAlreadyBooked:
                    return OperationResult.FailureResult("Failed to add appointment due to double-booking.");
                case enAddAppointmentResult.PatientHasActiveAppointment:
                    return OperationResult.FailureResult("Failed to add appointment due to Patient already has active appointment.");
                case enAddAppointmentResult.UnexpectedError:
                    return OperationResult.FailureResult("Failed to add appointment due to a database error.");
                default:
                    return OperationResult.FailureResult("An unknown error occurred while adding the appointment.");
            }
        }

        private OperationResult _UpdateAppointment()
        {
            bool result = AppointmentData.UpdateAppointment(AUDTO);
            if (result)
                return OperationResult.SuccessResult("Appointment updated successfully.");
            else
                return OperationResult.FailureResult("Failed to update appointment due to a database error.");
        }

        public OperationResult Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    OperationResult result = _AddNewAppointment();
                    if (result.Success)
                        Mode = enMode.Update;
                    return result;
                case enMode.Update:
                    return _UpdateAppointment();
                default:
                    return OperationResult.FailureResult("Invalid operation mode.");
            }
        }
    }
}
