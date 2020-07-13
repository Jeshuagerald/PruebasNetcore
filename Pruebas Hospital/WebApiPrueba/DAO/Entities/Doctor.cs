using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPrueba.DAO.Entities
{
    /// <summary>
    /// Clase que mapea los campos de la tabla Doctor de la Bd.
    /// </summary>
    public class Doctor
    {
        [Key]
        public int NumCredencial { get; set; }

        public string Nombre { get; set; }

        public string Especialidad { get; set; }

        public string Hospital { get; set; }
    }
}
