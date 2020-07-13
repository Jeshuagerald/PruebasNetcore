using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPrueba.DAO.Entities;

namespace WebApiPrueba.Services.Contracts
{
    public interface IDoctorService
    {
        IEnumerable<Doctor> GetAllDoctor();
        int CreateDoctor(Doctor doctor);
    }
}
