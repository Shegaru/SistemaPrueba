using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaPrueba.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaPrueba.DAL.Repositorios.Contrato;
using SistemaPrueba.DAL.Repositorios;

using SistemaPrueba.Utility;
using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.BLL.Servicios;



namespace SistemaPrueba.IOC
{
    public static class Dependencia
    {

        public static void inyectarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PRUEBA_YEMINUSContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("cadenaSQL"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddAutoMapper(typeof(AutoMapeo));
            
            services.AddScoped<IEncriptadoService, EncriptadoService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<IFibonacciService, FibonacciService>();
            services.AddScoped<IEncriptarService, EncriptarService>();
            services.AddScoped<IDesencriptarService, DesencriptarService>();

        }
    }
}
