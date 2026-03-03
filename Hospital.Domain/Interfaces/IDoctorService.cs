using Hospital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Interfaces
{
    public interface IDoctorService
    {
        void AddDoctor(Doctor doctor);
        IEnumerable<Doctor> GetAllDoctor();
        Doctor GetDoctorById(int id);
        void UpdateDoctor(Doctor doctor);
        void RemoveDoctor(int id);
    }
}
