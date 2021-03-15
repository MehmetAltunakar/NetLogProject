using EFCoreNetlogProject.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NetlogProject.Business.Abstract;
using NetlogProject.Business.Concrete;
using NetlogProject.Core.Auth;
using NetlogProject.Core.BaseRepository;
using NetlogProject.Core.Helpers;
using NetlogProject.Entity;
using NetlogProject.Repository.Abstract;
using NetlogProject.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetlogProject.WebApi
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
            services.AddControllers();

            #region DbContext
            services.AddTransient<DbContext, Context>();
            services.AddDbContext<Context>(options => options.UseNpgsql(Configuration.GetConnectionString("NpgsqlConnection")));
            services.AddScoped(typeof(IEntityRepository<>), typeof(efRepositoryBase<>));
            #endregion

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Netlog Proje Api", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });

            });
            #endregion

            services.AddTransient<IUserRepo, UserRepo>();
            services.AddTransient<IUserBusiness, UserBusiness>();

            services.AddTransient<IMaintenanceRepo, MaintenanceRepo>();
            services.AddTransient<IMaintenanceBusiness, MaintenanceBusiness>();

            services.AddTransient<IMaintenanceHistoryRepo, MaintenanceHistoryRepo>();
            services.AddTransient<IMaintenanceHistoryBusiness, MaintenanceHistoryBusiness>();

            services.AddTransient<IActionTypeRepo, ActionTypeRepo>();
            services.AddTransient<IActionTypeBusiness, ActionTypeBusiness>();

            services.AddTransient<IVehicleRepo, VehicleRepo>();
            services.AddTransient<IVehicleBusiness, VehicleBusiness>();

            services.AddTransient<IVehicleTypeRepo, VehicleTypeRepo>();
            services.AddTransient<IVehicleTypeBusiness, VehicleTypeBusiness>();

            services.AddTransient<IStatusRepo, StatusRepo>();
            services.AddTransient<IStatusBusiness, StatusBusiness>();

            services.AddTransient<IPictureGroupRepo, PictureGroupRepo>();
            services.AddTransient<IPictureGroupBusiness, PictureGroupBusiness>();




            #region Auth
            services.AddTransient<IAuthService, AuthManager>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            #endregion
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Netlog Proje Web Api");
            });
        }
    }
}
