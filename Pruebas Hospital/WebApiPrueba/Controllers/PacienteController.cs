using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPrueba.DAO;
using WebApiPrueba.DAO.Entities;
using WebApiPrueba.Services.Contracts;

namespace WebApiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        // GET api/paciente
        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> Get()
        {
            try
            {
                 return _pacienteService.GetAllPacientes().ToList();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

        // GET api/paciente/2
        [HttpGet("{NumSeguroSocial}")]
        public Paciente Get(int NumSeguroSocial)
        {
            return _pacienteService.GetPaciente(NumSeguroSocial);
        }

        //// POST api/paciente
        [HttpPost]
        public IActionResult Post([FromBody] Paciente paciente)
        {
            try
            {
                _pacienteService.CreatePaciente(paciente);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

        //// PUT api/paciente/5
        [HttpPut("{numSeguroSocial}")]
        public IActionResult Put([FromBody] Paciente paciente, int numSeguroSocial)
        {
            try
            {
                if (paciente.NumSeguroSocial != numSeguroSocial)
                {
                    return BadRequest("El Id no coincide con el especificado.");
                }

                var rowsAffected = _pacienteService.EditPaciente(paciente);

                if (rowsAffected == 0)
                {
                    return BadRequest("El Id especificado no existe en la Bd.");
                }
                
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

        //// DELETE api/values/5
        [HttpDelete("{numSeguroSocial}")]
        public IActionResult Delete(int numSeguroSocial)
        {
            try
            {
                var result = _pacienteService.DeletePaciente(numSeguroSocial);

                if (result.Equals(200))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }
    }
}
