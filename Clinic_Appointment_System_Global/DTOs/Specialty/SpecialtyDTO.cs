using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Global.DTOs.Specialty
{
    public class SpecialtyDTO
    {
        public int SpecialtyID { get; set; }
        public string SpecialtyName { get; set; }

        public SpecialtyDTO(int specialtyID, string specialtyName)
        {
            SpecialtyID = specialtyID;
            SpecialtyName = specialtyName;
        }
    }
}
