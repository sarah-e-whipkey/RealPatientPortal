using CoderCamps.Infrastructure;
using RealPatientPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPatientPortal.Infrastructure
{
    public class PatientRepository : GenericRepository<Patient>
    {
        public PatientRepository(ApplicationDbContext db) : base(db) { }
    }
}
