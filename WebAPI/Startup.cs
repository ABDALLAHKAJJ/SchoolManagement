using Hangfire;
using Hangfire.Common;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NLog;
using SchoolManagement.Automation.HangFire.JobAbstracts;
using SchoolManagement.Automation.HangFire.JobConcrete;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Business.Concrete;
using SchoolManagement.Data;
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Connections;
using SchoolManagement.Data.Repository;
using SchoolManagement.Libraries.Core.Extension;
using System;
using System.Configuration;
using System.IO;

namespace WebAPI
{
    public class Startup
    {
        //adel
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IRecurringJobManager recurringJobManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));

            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapSwagger();
                endpoints.MapControllers();
            });
            InitHangfire(app, recurringJobManager);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureLoggerService();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
            services.AddMvc();
            services.AddDbContext<SchoolManagementContext>(option =>
                option.UseSqlServer(ConnectionManager.GetConnectionString()));

            services.AddScoped<ISchoolBusiness, SchoolBusiness>();
            services.AddScoped<IStudentBusiness, StudentBusiness>();
            services.AddScoped<ITeacherBusiness, TeacherBusiness>();

            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();

            services.AddScoped<IJobAllStudentsRetriever, JobAllStudentsRetriever>();

            services.AddHangfire(config => { config.UseMemoryStorage(); });
            services.AddHangfireServer();
        }

        private void InitHangfire(IApplicationBuilder app, IRecurringJobManager recurringJobManager)
        {
            app.UseHangfireServer();
            app.UseHangfireDashboard();

            bool activateHangfireJobs = bool.Parse(ConfigurationManager.AppSettings["IsHangfireJobsActive"]);

            if (activateHangfireJobs)
            {
                recurringJobManager.AddOrUpdate(
                    "AllStudentsRetriever",
                    Job.FromExpression<IJobAllStudentsRetriever>(x => x.AllStudentsRetrieve()),
                    Configuration.GetValue<string>("AllStudentsRetriever")
                    );
            }
            else
            {
                recurringJobManager.RemoveIfExists("AllStudentsRetriever");
            }
        }
    }
}