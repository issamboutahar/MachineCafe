using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeApplication.Data;
using CafeApplication.Data.Models;
using CafeApplication.Service.Factory.Interfaces;
using CafeApplication.Service.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper.Execution;
using CafeApplication.Web.Models;

namespace CafeApplication.Web
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
            services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:CafeApplicationDB"]));
            services.AddMvc();
            services.AddScoped<IRepository<CafeApplication.Data.Models.Consommateur>, Repository<CafeApplication.Data.Models.Consommateur>>();
            services.AddScoped<IRepository<CafeApplication.Data.Models.Consommation>, Repository<CafeApplication.Data.Models.Consommation>>();
            services.AddScoped<IService, CafeApplication.Service.Service.Service>();
            

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IBreuvage, CafeApplication.Data.Models.Consommation>();
                cfg.CreateMap<CafeApplication.Data.Models.Consommation, IBreuvage>();
                cfg.CreateMap<TypeBoissonViewModel, IBreuvage>();
                cfg.CreateMap< IBreuvage, TypeBoissonViewModel>();
                
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            
            
            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
