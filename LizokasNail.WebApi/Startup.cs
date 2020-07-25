using LizokasNail.Core.BL;
using LizokasNail.Core.BL.Implementation;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.EF;
using LizokasNail.Core.Dao.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

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
            //var connection = ConfigurationManager.AppSetting["ConnectionStrings:Default"];
            //var connection = ConfigurationManager.AppSetting["ConnectionStrings:Mdf"];
            var connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True";
            var dbName = ConfigurationManager.AppSetting["ConnectionStrings:dbName"];
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), dbName);
            connection = string.Format(connection, path);
            services.AddDbContext<EfContext>(opt => opt.UseSqlServer(connection));

            services.AddControllers();

            services.AddScoped<IDataSource, EfDataSource>();

            #region Dao 

            services.AddScoped<IDao<User>, EntityDao<User>>();
            services.AddScoped<IDao<Record>, EntityDao<Record>>();
            services.AddScoped<IDao<Base>, EntityDao<Base>>();

            #endregion

            #region Bl

            services.AddScoped<IUserBl, UserBl>();
            services.AddScoped<IRecordBl, RecordBl>();
            services.AddScoped<IBaseBl, BaseBl>();

            #endregion

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "LizokasNails API", Version = "v1" });
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "LizokasNails API V1");
            });
        }
    }
}
