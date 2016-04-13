using RealPatientPortal.Infrastructure;
using RealPatientPortal.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Services
{
    public class PatientService
    {
        private PatientRepository _patientRepo;

        public PatientService(PatientRepository patientRepo)
        {
            _patientRepo = patientRepo;
        }

        public ICollection<PatientDTO> ListPatients()
        {
            return _patientRepo.List().Select(p => new PatientDTO
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Gender = p.Gender,
                DateOfBirth = p.DateOfBirth,
                SocialSecurityNumber = p.SocialSecurityNumber,
                Race = p.Race,
                Ethnicity = p.Ethnicity,
                Address = p.Address,
                City = p.City,
                State = p.State,
                Zipcode = p.Zipcode,
                MedicalHistory = p.MedicalHistory,
                PatientDoctors = p.PatientDoctors
            }).ToList();

        }
    }
}
