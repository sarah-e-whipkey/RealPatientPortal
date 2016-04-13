using RealPatientPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Services.DTOs
{
    public class DoctorDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<PatientDoctor> PatientDoctors { get; set; }

        public string Specialty { get; set; }
    }
}
