using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPrueba.DAO.Entities
{
    public class DoctorXPaciente
    {
        [Key]
        public int Id{ get; set; }

        [ForeignKey("FK_DoctorXPaciente_Paciente")]
        public int NumSeguroSocial { get; set; }

        [ForeignKey("FK_DoctorXPaciente_Doctor")]
        public int NumCredential { get; set; }
    }
}
