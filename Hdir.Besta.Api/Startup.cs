using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Hdir.Besta.Api.ViewModels;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using Hdir.Besta.Api.Infrastruktur;
using NLog;
using NLog.Config;
using Microsoft.AspNetCore.Authorization;

namespace Hdir.Besta.Api
{
    [Authorize(Roles = "Administrator, User")]
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
            // Plumbing
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Info { Title = "Tass - Api", Version = "v1" });
                
                x.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "SwaggerXMLApi.xml"));
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.SettOppService(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            //KonfigurerLogging(loggerFactory);
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "Tass - Api v0.1"));
        }

        private void KonfigurerLogging(ILoggerFactory loggerFactory)
        {
            LogManager.Configuration = new XmlLoggingConfiguration("nlog.config");

            loggerFactory.AddDebug();
        }
    }
}
