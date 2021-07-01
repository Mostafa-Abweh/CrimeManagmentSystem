using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Common;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;
using Tahaluf.CrimeManagementSystem.Infra.Common;
using Tahaluf.CrimeManagementSystem.Infra.Repository;
using Tahaluf.CrimeManagementSystem.Infra.Service;

namespace Tahaluf.CrimeManagementSystem.API
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
            services.AddScoped<IDBContext, DBContext>();

            //Repository
            services.AddScoped<IJudgeRepository, JudgeRepository>();
            services.AddScoped<ICrimeRepository, CrimeRepository>();
            services.AddScoped<IAcussedRepository, AcussedRepository>();
            services.AddScoped<IVictimRepository, VictimRepository>();
            services.AddScoped<IPermissionRepository, PermissonRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<IEvidenceRepository, EvidenceRepository>();
            services.AddScoped<ILawyerRepository, LawyerRepository>();
            services.AddScoped<IWitnessRepository, WitnessRepository>();
            services.AddScoped<IOfficerRepository, OfficerRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IFirstInformationReportRepoditory, FirstInformationReportRepoditory>();
            services.AddScoped<IPoliceStationRepository, PoliceStationRepository>();
            //Service
            services.AddScoped<IJudgeService, JudgeService>();
            services.AddScoped<ICrimeService, CrimeService>();
            services.AddScoped<IAcussedService, AcussedService>();
            services.AddScoped<IVictimService, VictimService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<ISectionService, SectionService>();
            services.AddScoped<IEvidenceService, EvidenceService>();
            services.AddScoped<ILawyerService, LawyerService>();
            services.AddScoped<IWitnessService, WitnessService>();
            services.AddScoped<IOfficerService, OfficerService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IFirstInformationReportService, FirstInformationReportService>();
            services.AddScoped<IPoliceStationService, PoliceStationService>();

            services.AddControllers();
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
