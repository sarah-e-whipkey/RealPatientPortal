using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Models
{
    public class PatientDoctor
    {
        public string PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }


        public string DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctors { get; set; }
    }
}
