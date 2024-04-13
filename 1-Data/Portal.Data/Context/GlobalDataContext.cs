using Microsoft.EntityFrameworkCore;
using Portal.Data.Entities.GlobalEntities;

namespace Portal.Data.Context
{
    public class GlobalDataContext : DbContext
    {
        private string GlobalConnStr { get; set; } = string.Empty;
        

        public GlobalDataContext(DbContextOptions<GlobalDataContext> options) : base(options)
        {
        }

        public GlobalDataContext(string ConnStr)
        {
            GlobalConnStr = ConnStr;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GlobalConnStr);
        }

        public DbSet<AirLine> Airlines { get; set; }
        public DbSet<AirPort> AirPorts { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<FlightCabinType> FlightCabinTypes { get; set; }
        public DbSet<FlightLineZone> FlightLineZones { get; set; }
        public DbSet<FlightLineDistance> FlightLineDistances { get; set; }
        public DbSet<FlightDirection> FlightDirections { get; set; }


        public DbSet<ModuleType> Modules { get; set; }
        public DbSet<Navigation> Navigations { get; set; }
        public DbSet<NavigationTranslation> NavigationTranslations { get; set; }

        public DbSet<HostelTypeSelectView> HostelTypeSelectViews { get; set; }
        public DbSet<BedTypeSelectView> BedTypeSelectViews { get; set; }
        public DbSet<RoomTypeSelectView> RoomTypeSelectViews { get; set; }
        public DbSet<ReservationStatusSelectView> ReservationStatusSelectViews { get; set; }
        public DbSet<LocationSelectListView> LocationSelectListViews { get; set; }
        public DbSet<InvoiceGroupSelectView> InvoiceGroupSelectViews { get; set; }
        public DbSet<InvoiceTypeSelectView> InvoiceTypeSelectView { get; set; }

        //Kontrol edilmeyenler

        public DbSet<City> Cities { get; set; }
        public DbSet<CityTranslation> CityTranslations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientUser> ClientUsers { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<ContinentTranslation> ContinentTranslations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryTranslation> CountryTranslations { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRateType> CurrencyRateTypes { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<CustomerTypeTranslation> CustomerTypeTranslations { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<DistrictTranslation> DistrictTranslations { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<FuelTypeTranslation> FuelTypeTranslations { get; set; }
        public DbSet<Language> Languages { get; set; }
       
        
        public DbSet<PassportType> PassportTypes { get; set; }
        public DbSet<PassportTypeTranslation>PassportTypeTranslations { get; set; }
        public DbSet<PayerType> Payers { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<SendInfoType> SendInfoTypes { get; set; }
        public DbSet<SendInfoTypeTranslation> SendInfoTypeTranslations { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<TicketStatusType> TicketStatusType { get; set; }
        public DbSet<VisaType> VisaTypes { get; set; }
        public DbSet<VisaTypeTranslation> VisaTypeTranslations { get; set; }
        public DbSet<SystemMessages> SystemMessages { get; set; }
        public DbSet<SystemMessagesTranslation> SystemMessagesTranslations { get; set; } 



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AirLine_Configuration());
            modelBuilder.ApplyConfiguration(new AirPort_Configuration());
            modelBuilder.ApplyConfiguration(new FlightCabinType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightLineZone_Configuration());
            modelBuilder.ApplyConfiguration(new FlightLineDistance_Configuration());
            modelBuilder.ApplyConfiguration(new FlightDirection_Configuration());
            modelBuilder.ApplyConfiguration(new BedTypeSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new HostelTypeSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new RoomTypeSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new ReservationStatusSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new LocationSelectListView_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceGroupSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceTypeSelectView_Configuration());



            modelBuilder.ApplyConfiguration(new CarBrand_Configuration());
            modelBuilder.ApplyConfiguration(new City_Configuration());
            modelBuilder.ApplyConfiguration(new CityTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new Client_Configuration());
            modelBuilder.ApplyConfiguration(new ClientUser_Configuration());
            modelBuilder.ApplyConfiguration(new Continent_Configuration());
            modelBuilder.ApplyConfiguration(new ContinentTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new Country_Configuration());
            modelBuilder.ApplyConfiguration(new CountryTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new Currency_Configuration());
            modelBuilder.ApplyConfiguration(new CurrencyRateType_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerType_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerTypeTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new District_Configuration());
            modelBuilder.ApplyConfiguration(new DistrictTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new FuelType_Configuration());
            modelBuilder.ApplyConfiguration(new FuelTypeTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new Language_Configuration());
            modelBuilder.ApplyConfiguration(new ModuleType_Configuration());
            modelBuilder.ApplyConfiguration(new Navigation_Configuration());
            modelBuilder.ApplyConfiguration(new NavigationTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new PassportType_Configuration());
            modelBuilder.ApplyConfiguration(new PassportTypeTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new PayerType_Configuration());
            modelBuilder.ApplyConfiguration(new PaymentType_Configuration());
            modelBuilder.ApplyConfiguration(new SendInfoType_Configuration());
            modelBuilder.ApplyConfiguration(new SendInfoTypeTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new TicketType_Configuration());
            modelBuilder.ApplyConfiguration(new TicketStatusType_Configuration());
            modelBuilder.ApplyConfiguration(new VisaType_Configuration());
            modelBuilder.ApplyConfiguration(new VisaTypeTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new SystemMessages_Configuration());
            modelBuilder.ApplyConfiguration(new SystemMessagesTranslation_Configuration());
        }
    }
}
