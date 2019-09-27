using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Parqueadero.data;
using Parqueadero.configuration;
using Parqueadero.domain.port;
using Parqueadero.infrastructure.adapter.repository;
using Parqueadero.domain.services;
using Parqueadero.domain.services.implementacion;

namespace Parqueadero
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        const string CONEXION_BD = "ParqueaderoDataBase";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<ParqueaderoContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString(CONEXION_BD)));
            inyectarRepository(services);
            InyectarServices(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private void inyectarRepository(IServiceCollection services)
        {
            services.AddScoped<IRepositoryTipoVehiculo, RepositoryTipoVehiculo>();
            services.AddScoped<IRepositoryPicoPlaca, RepositoryPicoPlaca>();
            services.AddScoped<IRepositoryVehiculo, RepositoryVehiculo>();
            services.AddScoped<IRepositoryTiquete, RepositoryTiquete>();
            services.AddScoped<IRepositoryTarifa, RepositoryTarifa>();
        }

        private void InyectarServices(IServiceCollection services)
        {
            services.AddScoped<IVehiculoService, VehiculoService>();
            services.AddScoped<ITipoVehiculoService, TipoVehiculoService>();
            services.AddScoped<IPicoPlacaService, PicoPlacaService>();
            services.AddScoped<ITarifaService, TarifaService>();
            services.AddScoped<ITiqueteService, TiqueteService>();
            services.AddScoped<IVigilanteService, VigilanteService>();
        }
    }
}
