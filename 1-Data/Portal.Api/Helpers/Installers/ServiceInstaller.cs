using Microsoft.Extensions.DependencyInjection;
using MioPortal.Api.DataServis;
using Portal.Api.DataServis;
using Portal.Api.DataServis.GlobalContextService;

namespace Portal.Api.Helpers.Installers
{
    public static class ServiceInstaller
    {
        public static IServiceCollection RegisterPortalServices(this IServiceCollection services)
        {
            services.AddTransient<ISessionService, SessionService>();
            services.AddScoped<IGlobalContextService, GlobalContextService>();
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ISystemService, SystemService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IFlightTicketService, FlightTicketService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IOrganisationService, OrganisationService>();
            services.AddScoped<IOtherProcessService, OtherProcessService>();
            services.AddScoped<IRentACarService, RentACarService>();
            services.AddScoped<ITourService, TourService>();
            services.AddScoped<ITransferService, TransferService>();
            services.AddScoped<IVisaService, VisaService>();
            services.AddScoped<IClientDefinitionsService, ClientDefinitionsService>();

            return services;
        }
    }
}
