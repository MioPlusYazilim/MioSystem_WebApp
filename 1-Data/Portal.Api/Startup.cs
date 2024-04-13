using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Portal.Api.Helpers.Installers;
using Portal.Api.Helpers.Security;
using Portal.Api.Mapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Portal.Api
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
            // services.AddControllers();
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddSession();
            // services.AddMvc();
            services.AddMvc(option => option.EnableEndpointRouting = false)
                 .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddDataContext(Configuration);
            services.RegisterPortalServices();

            services.AddTokenAuthentication(Configuration);

            //AutoMap Ekleniyor;
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use((httpContext, next) =>
                {
                    List<string> _supportedLanguages = new List<string>() { "tr-TR", "en-US" };
                    var userLangs = httpContext.Request.Headers["Accept-Language"].ToString();
                    var lang = userLangs.Split(',').FirstOrDefault();

                    if (_supportedLanguages.Contains(lang) == false)
                        lang = "tr-TR";

                    //You could set the environment culture based on the language.
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
                    Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

                    //you could save the language preference for later use as well.
                    httpContext.Items["SelectedLng"] = lang;
                    httpContext.Items["ClientCulture"] = Thread.CurrentThread.CurrentUICulture.Name;


                    return next();
                });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseSession();
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
