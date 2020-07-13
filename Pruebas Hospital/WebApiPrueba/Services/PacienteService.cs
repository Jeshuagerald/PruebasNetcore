using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using WebApiPrueba.DAO;
using WebApiPrueba.DAO.Entities;
using WebApiPrueba.Services.Contracts;

namespace WebApiPrueba.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly HospitalFrameworkContext _hospitalFrameworkContext;

        public PacienteService(HospitalFrameworkContext context)
        {
            _hospitalFrameworkContext = context ?? throw new ArgumentNullException(nameof(context));
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        /// <summary>
        /// Obtiene la lista total de pacientes
        /// </summary>
        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _hospitalFrameworkContext.Paciente.ToList();
        }

        /// <summary>
        /// Obtiene el paciente de un id especifico
        /// </summary>
        public Paciente GetPaciente(int NumSeguroSocial)
        {
            Paciente paciente = _hospitalFrameworkContext.Paciente.FirstOrDefault(d => d.NumSeguroSocial == NumSeguroSocial);

            return paciente;
        }

        /// <summary>
        /// Inserta un nuevo paciente
        /// </summary>
        /// <param name="paciente"></param>
        public int CreatePaciente(Paciente paciente)
        {
            _hospitalFrameworkContext.Paciente.Add(paciente);
            
            return _hospitalFrameworkContext.SaveChanges();
        }

        /// <summary>
        /// Edita un paciente existente
        /// </summary>
        /// <param name="paciente"></param>
        public int EditPaciente(Paciente paciente)
        {
            int valueAffected = 0;
            var pacienteExists = GetPaciente(paciente.NumSeguroSocial);

            if (pacienteExists != null)
            {
                _hospitalFrameworkContext.Entry(paciente).State = EntityState.Modified;
                valueAffected = _hospitalFrameworkContext.SaveChanges();
            }

            return valueAffected;
        }

        /// <summary>
        /// Eliminar un paciente especificado
        /// </summary>
        /// <param name="numSeguroSocial"></param>
        public int DeletePaciente(int numSeguroSocial)
        {
            var color = _hospitalFrameworkContext.Paciente.FirstOrDefault(d => d.NumSeguroSocial == numSeguroSocial);

            if (color == null)
            {
                return 404;
            }

            _hospitalFrameworkContext.Paciente.Remove(color);
            _hospitalFrameworkContext.SaveChanges();
            return 200;
        }
    }
}
