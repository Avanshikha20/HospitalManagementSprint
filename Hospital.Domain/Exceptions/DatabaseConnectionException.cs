using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Exception
{
    public class DatabaseConnectionException: Exception
    {
        public DatabaseConnectionException(string message) : base(message) 
        { 
        }
    }
}
