using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPrueba.DAO.Entities;
using WebApiPrueba.Services.Contracts;

namespace WebApiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        // GET api/doctor
        [HttpGet]
        public ActionResult<IEnumerable<Doctor>> Get()
        {
            try
            {
                return _doctorService.GetAllDoctor().ToList();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

        //// POST api/doctor
        [HttpPost]
        public IActionResult Post([FromBody] Doctor doctor)
        {
            try
            {
                _doctorService.CreateDoctor(doctor);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }
    }
}
