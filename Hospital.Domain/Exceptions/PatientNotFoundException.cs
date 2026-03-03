using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Exception
{
    public class PatientNotFoundException : Exception
    {
        public PatientNotFoundException(string message) : base(message)
        {
        }
    }
}
