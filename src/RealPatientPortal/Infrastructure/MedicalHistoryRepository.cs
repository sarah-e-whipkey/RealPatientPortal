using CoderCamps.Infrastructure;
using RealPatientPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Infrastructure
{
    public class MedicalHistoryRepository : GenericRepository<MedicalHistory>
    {
        public MedicalHistoryRepository(ApplicationDbContext db) : base(db) { }
    }
}
