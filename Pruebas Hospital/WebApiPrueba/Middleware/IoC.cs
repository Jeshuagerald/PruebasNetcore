using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPrueba.Services;
using WebApiPrueba.Services.Contracts;

namespace WebApiPrueba.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            services.AddScoped<IPacienteService, PacienteService>();
            services.AddScoped<IDoctorService, DoctorService>();
            return services;
        }
    }
}
