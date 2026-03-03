using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Exception
{
    
    public class InvalidDoctorException : Exception
    {
        public InvalidDoctorException(string message) : base(message)
        {
        }
    }
}
