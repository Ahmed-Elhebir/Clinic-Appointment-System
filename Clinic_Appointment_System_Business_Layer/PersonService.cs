using System;
using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs;

namespace Clinic_Appointment_System_Business_Layer
{
    public class PersonService
    {
        public bool IsNationalNoExists(string nationalNo)
        {
            return PersonData.IsNationalNoExists(nationalNo);
        }

    }
}
