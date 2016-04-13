using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Services.DTOs
{
    public class MedicalHistoryDTO
    {
        [Required(ErrorMessage = "Patient height required")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Patient weight required")]
        public double Weight { get; set; }

        public double BMI { get; set; }

        [Required(ErrorMessage = "Patient condition(s) required")]
        public string Condition { get; set; }

        public string Allergy { get; set; }

        public string Medications { get; set; }
    }
}
