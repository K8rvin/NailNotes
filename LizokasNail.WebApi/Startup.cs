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
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //����������� � ��
            var connection = ConfigurationManager.AppSetting["ConnectionStrings:Default"];
            //var connection = ConfigurationManager.AppSetting["ConnectionStrings:Mdf"];
            //var connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True";
            //var dbName = ConfigurationManager.AppSetting["ConnectionStrings:dbName"];
            //var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), dbName);
            //connection = string.Format(connection, path);
            services.AddDbContext<EfContext>(opt => opt.UseSqlServer(connection));

            services.AddControllers();

            services.AddScoped<IDataSource, EfDataSource>();

            #region Dao 

            services.AddScoped<IDao<User>, EntityDao<User>>();
            services.AddScoped<IDao<Record>, EntityDao<Record>>();
            services.AddScoped<IDao<Base>, EntityDao<Base>>();
            services.AddScoped<IDao<Color>, EntityDao<Color>>();
            services.AddScoped<IDao<Top>, EntityDao<Top>>();
            services.AddScoped<IDao<Design>, EntityDao<Design>>();
            services.AddScoped<IDao<Check>, EntityDao<Check>>();
            services.AddScoped<IDao<Check2Base>, EntityDao<Check2Base>>();
            services.AddScoped<IDao<Check2Color>, EntityDao<Check2Color>>();
            services.AddScoped<IDao<Check2Top>, EntityDao<Check2Top>>();
            services.AddScoped<IDao<Check2Design>, EntityDao<Check2Design>>();
            services.AddScoped<IDao<Procedure>, EntityDao<Procedure>>();
            services.AddScoped<IDao<Record2Procedure>, EntityDao<Record2Procedure>>();
            services.AddScoped<IDao<PriceCost>, EntityDao<PriceCost>>();

            #endregion

            #region Bl

            services.AddScoped<IUserBl, UserBl>();
            services.AddScoped<IRecordBl, RecordBl>();
            services.AddScoped<IBaseBl, BaseBl>();
            services.AddScoped<IColorBl, ColorBl>();
            services.AddScoped<ITopBl, TopBl>();
            services.AddScoped<IDesignBl, DesignBl>();
            services.AddScoped<ICheckBl, CheckBl>();
            services.AddScoped<IProcedureBl, ProcedureBl>();
            services.AddScoped<IReportBl, ReportBl>();
            services.AddScoped<IPriceCostBl, PriceCostBl>();

            #endregion

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "LizokasNails API", Version = "v1" });
            });

            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = true;
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
