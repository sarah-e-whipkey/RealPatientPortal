using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RealPatientPortal.Services;
using RealPatientPortal.Services.DTOs;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RealPatientPortal.Controllers
{
    [Route("api/[controller]")]
    public class PatientsController : Controller
    {
        private PatientService _patientServ;

        public PatientsController(PatientService patientServ)
        {
            _patientServ = patientServ;
        }

        // GET: api/values
        [HttpGet]
        public ICollection<PatientDTO> Get()
        {
            return _patientServ.ListPatients();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
