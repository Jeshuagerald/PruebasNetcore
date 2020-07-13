using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPrueba.DAO.Entities
{
    public class Paciente
    {
        [Key]
        public int NumSeguroSocial { get; set; }

        public string Nombre { get; set; }

        public string CodPostal { get; set; }

        public string Telefono { get; set; }
    }
}
