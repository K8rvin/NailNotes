using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using LizokasNail.Core.BL;
using LizokasNail.Core.BL.Implementation;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.EF;
using LizokasNail.Core.Dao.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace LizokasNail.WebApi
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
            //подключение к БД
            //var connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            var connection = ConfigurationManager.ConnectionStrings["Release"].ConnectionString;            
            services.AddDbContext<EfContext>(opt => opt.UseSqlServer(connection));

            services.AddControllers();

            services.AddScoped<IDataSource, EfDataSource>();

            #region Dao 

            services.AddScoped<IDao<User>, EntityDao<User>>();

            #endregion

            #region Bl

            services.AddScoped<IUserBl, UserBl>();

            #endregion

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
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
        }
    }
}
