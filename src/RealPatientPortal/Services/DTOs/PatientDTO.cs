using RealPatientPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Services.DTOs
{
    public class PatientDTO
    {
        [Required(ErrorMessage = "First Name required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender must be selected")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date of birth required")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Social Security Number required")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$)", ErrorMessage = "Valid SSN required")]
        [Display(Name = "Social Security Number")]
        public string SocialSecurityNumber { get; set; }

        [Required(ErrorMessage = "Race required")]
        [Display(Name = "Race")]
        public string Race { get; set; }

        [Required(ErrorMessage = "Ethnicity required")]
        [Display(Name = "Ethnicity")]
        public string Ethnicity { get; set; }

        [Required(ErrorMessage = "Address required")]
        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City required")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "State required")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zipcode required")]
        [MaxLength(5)]
        [Display(Name = "Zipcode")]
        public string Zipcode { get; set; }

        public MedicalHistory MedicalHistory { get; set; }

        public ICollection<PatientDoctor> PatientDoctors { get; set; }
    }
}
