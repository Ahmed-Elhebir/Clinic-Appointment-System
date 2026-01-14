using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global.DTOs.Specialty;
using System.Collections.Generic;

namespace Clinic_Appointment_System_Business_Layer
{
    public class SpecialtyService
    {
        public static List<SpecialtyDTO> GetAllSpecialties()
        {
            return SpecialtyData.GetAllSpecialties();
        }

        public static SpecialtyDTO FindByID(int id)
        {
            return SpecialtyData.GetSpecialtyByID(id);
        }

        public static SpecialtyDTO GetSpecialtyByName(string specialtyName)
        {
            return SpecialtyData.GetSpecialtyByName(specialtyName);
        }

    }
}
