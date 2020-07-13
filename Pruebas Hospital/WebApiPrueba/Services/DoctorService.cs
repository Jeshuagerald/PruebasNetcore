using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPrueba.DAO;
using WebApiPrueba.DAO.Entities;
using WebApiPrueba.Services.Contracts;

namespace WebApiPrueba.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly HospitalFrameworkContext _hospitalFrameworkContext;

        public DoctorService(HospitalFrameworkContext context)
        {
            _hospitalFrameworkContext = context ?? throw new ArgumentNullException(nameof(context));
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        /// <summary>
        /// Obtiene la lista total de doctores
        /// </summary>
        public IEnumerable<Doctor> GetAllDoctor()
        {
            return _hospitalFrameworkContext.Doctor.ToList();
        }

        /// <summary>
        /// Insertar un nuevo doctores
        /// </summary>
        public int CreateDoctor(Doctor doctor)
        {
            _hospitalFrameworkContext.Doctor.Add(doctor);
            
            return _hospitalFrameworkContext.SaveChanges();
        }
    }
}
