using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RealPatientPortal.Services;
using RealPatientPortal.Services.DTOs;
using Microsoft.AspNet.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RealPatientPortal.Controllers
{
    [Route("api/[controller]")]
    public class MedicalHistoriesController : Controller
    {
        private MedicalHistoryService _medicalHistoryServ;

        public MedicalHistoriesController(MedicalHistoryService medicalHistoryServ)
        {
            _medicalHistoryServ = medicalHistoryServ;
        }

        // GET: api/values
        [HttpGet]
        public ICollection<MedicalHistoryDTO> Get()
        {
            return _medicalHistoryServ.ListMedicalHistory();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        public IActionResult Post([FromBody] MedicalHistoryDTO mh)
        {
            if (ModelState.IsValid)
            {
                _medicalHistoryServ.AddMedicalHistory(mh);


                return Ok();
            }
            else
            {
                return HttpBadRequest(ModelState);
            }
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
