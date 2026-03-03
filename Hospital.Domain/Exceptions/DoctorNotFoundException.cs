using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Exception
{
    public class DoctorNotFoundException : Exception
    {
        public DoctorNotFoundException(string message) : base(message)
        {
        }
    }
}
