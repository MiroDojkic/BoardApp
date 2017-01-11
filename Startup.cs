using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FesbBoard.Data.Models;
using FesbBoard.Domain.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace FesbBoard
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddDbContext<FesbBoardDbContext>(options => options.UseSqlite("Filename=./fesbboard.db"));
            services.AddSingleton<IUserQueries, UserQueries>();
            services.AddSingleton<IBoardQueries, BoardQueries>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseStaticFiles();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "userRoute",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "User", action = "GetAll" }
                );
            });
        }
    }
}
