using RealPatientPortal.Infrastructure;
using RealPatientPortal.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Services
{
    public class DoctorService
    {
        private DoctorRepository _doctorRepo;

        public DoctorService(DoctorRepository doctorRepo)
        {
            _doctorRepo = doctorRepo;
        }

        public ICollection<DoctorDTO> ListDoctors()
        {
            return _doctorRepo.List().Select(d => new DoctorDTO
            {
                FirstName = d.FirstName,
                LastName = d.LastName,
                Specialty = d.Specialty
            }).ToList();
        }
    }
}
