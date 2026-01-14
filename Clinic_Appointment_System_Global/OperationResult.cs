using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Global
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public static OperationResult SuccessResult(string message = "", object data = null)
        {
            return new OperationResult()
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static OperationResult FailureResult(string message)
        {
            return new OperationResult()
            {
                Success = false,
                Message = message,
                Data = null
            };
        }


    }
}
