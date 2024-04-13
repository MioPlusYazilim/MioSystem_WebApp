using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portal.Data.Context;
using Portal.Helpers;

namespace Portal.Api.Helpers.Installers
{
    public static class ContextInstaller
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            string ConnStr = configuration.GetConnectionString("PortalConnStr");
            using (CryptoManager engine = new CryptoManager(""))
                ConnStr = engine.Decrypt(ConnStr);
            services.AddDbContext<GlobalDataContext>(options => options.UseSqlServer(ConnStr).EnableSensitiveDataLogging().EnableDetailedErrors());

            services.AddDbContext<ClientDataContext>();
            //services.AddScoped<DbContext, DataContext>();

            return services;
        }

    }
}
