using DemoLibrary.Application.Interfaces.Repositories;
using DemoLibrary.Application.Models.Common;
using DemoLibrary.Infrastructure.Persistence;
using DemoLibrary.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Web;

namespace DemoLibrary.Infrastructure
{
    public static class Extensions
    {

        /// <summary>
        /// Agregamos la infraestructura de la aplicación.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <param name="IsLocal"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration, bool IsLocal)
        {

            services.AddDbContext<BaseDbContext>(opstions =>
            {
                opstions.UseSqlServer(Configuration.GetConnectionString("DEV_STANDAR"));
                if (IsLocal)
                {
                    opstions.LogTo(Console.WriteLine, LogLevel.Information)
                            .EnableSensitiveDataLogging();
                }
            });

            //agregamos todos los repositoprios genéricos en una sola linea.
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<HeaderToken>((se) =>
            {
                var _HttpContext = se.GetRequiredService<IHttpContextAccessor>();
                if (_HttpContext.HttpContext != null)
                {
                    var request = _HttpContext.HttpContext.Request.Headers;
                    var header = request.FirstOrDefault(x => x.Key.ToLower() == "headertoken");

                    if (!string.IsNullOrWhiteSpace(header.Value))
                    {
                        var decodedHeaderToken = HttpUtility.HtmlDecode(header.Value);
                        var result = JsonConvert.DeserializeObject<HeaderToken>(decodedHeaderToken);
                        return result;
                    }
                }
                return null;
            });


            services.AddScoped<ILogDbRepository, LogDbRepository>();
            services.AddScoped<ILogJobRepository, LogJobRepository>();
            services.AddScoped<ILogHttpRepository, LogHttpRepository>();
            services.AddScoped<IAuditHttpRepository, AuditHttpRepository>();
            services.AddScoped<IAuditEndpointRepository, AuditEndpointRepository>();


            services.AddScoped<IMasterTableRepository, MasterTableRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IBookRepository, BookRepository>();


            //TODO: Solo sirve de ejemplo de errores


            return services;
        }


        public static IServiceCollection AddInfrastructureExternalServices(this IServiceCollection services, IConfiguration Configuration)
        {

       


            return services;
        }


    }
}
