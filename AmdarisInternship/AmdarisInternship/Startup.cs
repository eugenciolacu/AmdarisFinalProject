using AmdarisInternship.API.Mappings;
using AmdarisInternship.API.Services;
using AmdarisInternship.API.Services.Interfaces;
using AmdarisInternship.Infrastructure.Context;
using AmdarisInternship.Infrastructure.Repositories;
using AmdarisInternship.Infrastructure.Repositories.CustomRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AmdarisInternship
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AmdarisInternshipContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnection"));
            });

            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new ModuleMappingProfile());
            });

            ConfigureSwagger(services);

            services.AddControllers();

            services.AddSingleton(mapperConfig.CreateMapper());

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IModuleRepository, ModuleRepository>();

            services.AddScoped<IModuleModuleGradingsService, ModuleModuleGradingsService>();
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
                app.UseExceptionHandler("/error");
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                "Swagger Demo API v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void ConfigureSwagger (IServiceCollection services)
        {
            var info = new OpenApiInfo()
            {
                Version = "v1",
                Title = "Amdaris Internship API",
                Description = "Amdaris Internship lesson calendar",
            };

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", info);
            });
        }
    }
}
