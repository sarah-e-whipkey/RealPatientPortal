using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Models
{
    public class Doctor : ApplicationUser
    {
        public ICollection<PatientDoctor> PatientDoctors { get; set; }

        public string Specialty { get; set; }
    }
}
