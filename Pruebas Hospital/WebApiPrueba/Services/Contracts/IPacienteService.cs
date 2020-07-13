using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPrueba.DAO.Entities;

namespace WebApiPrueba.Services.Contracts
{
    public interface IPacienteService
    {
        IEnumerable<Paciente> GetAllPacientes();
        int CreatePaciente(Paciente paciente);
        int EditPaciente(Paciente paciente);
        int DeletePaciente(int numSeguroSocial);
        Paciente GetPaciente(int NumSeguroSocial);
    }
}
