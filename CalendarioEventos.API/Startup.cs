using System;
using CalendarioEventos.Entities;
using CalendarioEventos.Services;
using CalendarioEventos.Data;

namespace CalendarioEventos.API
{
    public class Startup{
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddCors();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin() );
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}

