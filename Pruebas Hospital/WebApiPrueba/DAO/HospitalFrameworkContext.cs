using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPrueba.DAO.Entities;

namespace WebApiPrueba.DAO
{
    /// Se Hereda la clase al DbContext EntityFramework
    public class HospitalFrameworkContext : DbContext
    {
        ///Se recibe las opciones de la conexión, especificadas en el 
        ///método ConfigureServices de la clase Startup.
        public HospitalFrameworkContext(DbContextOptions<HospitalFrameworkContext> options) : base(options)
        { }
        
        /// Se especifica el modelo que mapea la tabla de la base de Datos.
        public DbSet<Doctor> Doctor { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<DoctorXPaciente> DoctorXPaciente { get; set; }
    }
}
