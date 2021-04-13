using Aula2.Context;
using Aula2.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ProjetoWeb.Adapters;
using ProjetoWeb.Bordas.Adapter;
using ProjetoWeb.Bordas.Repositorios;
using ProjetoWeb.Bordas.UseCases;
using ProjetoWeb.Repositorio;
using ProjetoWeb.UseCase;
using System;

namespace Aula2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //linha de comando p reconhecer o banco com nome do arq criado LocalDvContext
            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
            (Environment.GetEnvironmentVariable("CONNECTION_STRING")));

            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<ICriarPlantaUseCase, CriarPlantaUseCase>();
            services.AddScoped<IEditarPlantaUseCase, EditarPlantaUseCase>();
            services.AddScoped<IDeletarPlantaUseCase, DeletarPlantaUseCase>();
            services.AddScoped<ILerPorIdPlantaUseCase, LerPorIdPlantaUseCase>();
            services.AddScoped<ILerTodosPlantaUseCase, LerTodosPlantaUseCase>();

            services.AddScoped<IPlantaRepositorio, PlantaRepositorio>();
            services.AddScoped<IPlantaAdapter, PlantaAdapter>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "bootcamp", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "bootcamp v1"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
