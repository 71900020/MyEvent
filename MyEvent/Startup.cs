using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyEvent.Data.Context;
using MyEvent.Data.Interfaces;
using MyEvent.Data.Repository;
using MyEvent.Models;
using MyEvent.Services;
using MyEvent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent
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
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<SqlContext>(options => options.UseSqlServer(connectionString));
            services.AddControllersWithViews();

            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();

            services.AddScoped<ILocalService, LocalService>();
            services.AddScoped<ILocalRepository, LocalRepository>();
            services.AddScoped<IBaseService<Local>, BaseService<Local>>();
            services.AddScoped<IBaseRepository<Local>, BaseRepository<Local>>();

            services.AddScoped<IEventoService, EventoService>();
            services.AddScoped<IEventoRepository, EventoRepository>();
            services.AddScoped<IBaseService<Evento>, BaseService<Evento>>();
            services.AddScoped<IBaseRepository<Evento>, BaseRepository<Evento>>();

            services.AddScoped<IConvidadoService, ConvidadoService>();
            services.AddScoped<IConvidadoRepository, ConvidadoRepository>();
            services.AddScoped<IBaseService<Convidado>, BaseService<Convidado>>();
            services.AddScoped<IBaseRepository<Convidado>, BaseRepository<Convidado>>();

            services.AddScoped<IGastoService, GastoService>();
            services.AddScoped<IGastoRepository, GastoRepository>();
            services.AddScoped<IBaseService<Gasto>, BaseService<Gasto>>();
            services.AddScoped<IBaseRepository<Gasto>, BaseRepository<Gasto>>();

            services.AddScoped<ITarefaService, TarefaService>();
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<IBaseService<Tarefa>, BaseService<Tarefa>>();
            services.AddScoped<IBaseRepository<Tarefa>, BaseRepository<Tarefa>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}");
            });
        }
    }
}
