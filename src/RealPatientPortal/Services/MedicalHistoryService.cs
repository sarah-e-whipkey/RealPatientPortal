using RealPatientPortal.Infrastructure;
using RealPatientPortal.Models;
using RealPatientPortal.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Services
{
    public class MedicalHistoryService
    {
        private MedicalHistoryRepository _medicalHistoryRepo;

        public MedicalHistoryService(MedicalHistoryRepository medicalHistoryRepo)
        {
            _medicalHistoryRepo = medicalHistoryRepo;
        }

        public ICollection<MedicalHistoryDTO> ListMedicalHistory()
        {
            return _medicalHistoryRepo.List().Select(mh => new MedicalHistoryDTO
            {
                Height = mh.Height,
                Weight = mh.Weight,
                BMI = mh.BMI,
                Condition = mh.Condition,
                Allergy = mh.Allergy,
                Medications = mh.Medications
            }).ToList();
        }

        public void AddMedicalHistory(MedicalHistoryDTO mh)
        {
            var medHx = new MedicalHistory
            {
                Height = mh.Height,
                Weight = mh.Weight,
                BMI = mh.BMI,
                Condition = mh.Condition,
                Allergy = mh.Allergy,
                Medications = mh.Medications
            };

            _medicalHistoryRepo.Add(medHx);
            _medicalHistoryRepo.SaveChanges();


        }
    }
}
