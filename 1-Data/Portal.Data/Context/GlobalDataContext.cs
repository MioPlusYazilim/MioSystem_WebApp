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

        //****** özkan yaptı

        public DbSet<AccountingSystem> AccountingSystems { get; set; }
        public DbSet<AirLine> Airlines { get; set; }
        public DbSet<AirPort> AirPorts { get; set; }
        public DbSet<AutoInvoiceType> AutoInvoiceTypes { get; set; }
        public DbSet<AutoNumberType> AutoNumberTypes { get; set; }
        public DbSet<AutoServiceType> AutoServiceTypes { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarClassType> CarClassTypes { get; set; }
        public DbSet<CareerGroup> CareerGroups { get; set; }
        public DbSet<CarSegmentType> CarSegmentTypes { get; set; }
        public DbSet<Categories> Categoriess { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<CorporateType> CorporateTypes { get; set; }
        public DbSet<CreditCardType> CreditCardTypes { get; set; }
        public DbSet<DeclarationType> DeclarationTypes { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<ExceptionCode> ExceptionCodes { get; set; }
        public DbSet<ExceptionType> ExceptionTypes { get; set; }
        public DbSet<ExceptionType> FlightDistances { get; set; }
        public DbSet<FlightFlexType> FlightFlexTypes { get; set; }
        public DbSet<FlightFlexType> FlightFoodTypes { get; set; }
        public DbSet<FlightLineDistance> FlightLineDistances { get; set; }
        public DbSet<FlightLineType> FlightLineTypes { get; set; }
        public DbSet<FlightLineZone> FlightLineZones { get; set; }
        public DbSet<FlightSeatType> FlightSeatTypes { get; set; }
        public DbSet<FlightStatusType> FlightStatusTypes { get; set; }
        public DbSet<FlightSupplierType> FlightSupplierTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<GlobalDeclaration> GlobalDeclarations { get; set; }
        public DbSet<GlobalModule> GlobalModules { get; set; }
        public DbSet<GlobalReportType> GlobalReportTypes { get; set; }
        public DbSet<GlobalTranslation> GlobalTranslations { get; set; }
        public DbSet<HotelBedType> HotelBedTypes { get; set; }
        public DbSet<HotelClassType> HotelClassTypes { get; set; }
        public DbSet<HotelHostelType> HotelHostelTypes { get; set; }
        public DbSet<HotelType> HotelTypes { get; set; }
        public DbSet<IntegratorSystem> IntegratorSystems { get; set; }
        public DbSet<InvoiceOptionType> InvoiceOptionTypes { get; set; }
        public DbSet<InvoiceTransactionType> InvoiceTransactionTypes { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<LanguageType> LanguageTypes { get; set; }
        public DbSet<ModuleType> ModuleTypes { get; set; }
        public DbSet<MonthType> MonthTypes { get; set; }
        public DbSet<PassengerType> PassengerTypes { get; set; }
        public DbSet<PassportType> PassportTypes { get; set; }
        public DbSet<PayerType> PayerTypes { get; set; }
        public DbSet<PaymentTermType> PaymentTermTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<RegionType> RegionTypes { get; set; }
        public DbSet<ReportOptionType> ReportOptionTypes { get; set; }
        public DbSet<RoleDate> RoleDates { get; set; }
        public DbSet<SendInfoType> SendInfoTypes { get; set; }
        public DbSet<ShipCabinType> ShipCabinTypes { get; set; }
        public DbSet<SourceType> SourceTypes { get; set; }
        public DbSet<SpecialCodeType> SpecialCodeTypes { get; set; }
        public DbSet<SystemUIElements> SystemUIElementss { get; set; }
        public DbSet<TitleType> TitleTypes { get; set; }
        public DbSet<TransactionGroup> TransactionGroups { get; set; }
        public DbSet<UnitCodeType> UnitCodeTypes { get; set; }
        public DbSet<WorkerType> WorkerTypes { get; set; }
        public DbSet<VisaType> VisaTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRateType> CurrencyRateTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientUser> ClientUsers { get; set; }
        public DbSet<SystemMessages> SystemMessages { get; set; }
        public DbSet<SystemMessagesTranslation> SystemMessagesTranslations { get; set; }
        public DbSet<FlightCabinType> FlightCabinTypes { get; set; }
        public DbSet<Navigation> Navigations { get; set; }
        public DbSet<NavigationTranslation> NavigationTranslations { get; set; }

        //****** özkan yaptı 



        public DbSet<HostelTypeSelectView> HostelTypeSelectViews { get; set; }
        public DbSet<RoomTypeSelectView> RoomTypeSelectViews { get; set; }
        public DbSet<ReservationStatusSelectView> ReservationStatusSelectViews { get; set; }
        public DbSet<LocationSelectListView> LocationSelectListViews { get; set; }
        public DbSet<InvoiceGroupSelectView> InvoiceGroupSelectViews { get; set; }
        public DbSet<InvoiceTypeSelectView> InvoiceTypeSelectView { get; set; }

        //Kontrol edilmeyenler

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //***** özkan yaptı
            modelBuilder.ApplyConfiguration(new AccountingSystem_Configuration());
            modelBuilder.ApplyConfiguration(new AirLine_Configuration());
            modelBuilder.ApplyConfiguration(new AirPort_Configuration());
            modelBuilder.ApplyConfiguration(new AutoInvoiceType_Configuration());
            modelBuilder.ApplyConfiguration(new AutoNumberType_Configuration());
            modelBuilder.ApplyConfiguration(new AutoServiceType_Configuration());
            modelBuilder.ApplyConfiguration(new CarBrand_Configuration());
            modelBuilder.ApplyConfiguration(new CarClassType_Configuration());
            modelBuilder.ApplyConfiguration(new CareerGroup_Configuration());
            modelBuilder.ApplyConfiguration(new CarSegmentType_Configuration());
            modelBuilder.ApplyConfiguration(new Categories_Configuration());
            modelBuilder.ApplyConfiguration(new City_Configuration());
            modelBuilder.ApplyConfiguration(new CorporateType_Configuration());
            modelBuilder.ApplyConfiguration(new CreditCardType_Configuration());
            modelBuilder.ApplyConfiguration(new DeclarationType_Configuration());
            modelBuilder.ApplyConfiguration(new Direction_Configuration());
            modelBuilder.ApplyConfiguration(new ExceptionCode_Configuration());
            modelBuilder.ApplyConfiguration(new ExceptionType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightCabinType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightDistance_Configuration());
            modelBuilder.ApplyConfiguration(new FlightFlexType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightFoodType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightLineDistance_Configuration());
            modelBuilder.ApplyConfiguration(new FlightLineType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightLineZone_Configuration());
            modelBuilder.ApplyConfiguration(new FlightSeatType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightStatusType_Configuration());
            modelBuilder.ApplyConfiguration(new FlightSupplierType_Configuration());
            modelBuilder.ApplyConfiguration(new FuelType_Configuration());
            modelBuilder.ApplyConfiguration(new GlobalDeclaration_Configuration());
            modelBuilder.ApplyConfiguration(new GlobalModule_Configuration());
            modelBuilder.ApplyConfiguration(new GlobalReportType_Configuration());
            modelBuilder.ApplyConfiguration(new GlobalTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new HotelBedType_Configuration());
            modelBuilder.ApplyConfiguration(new HotelClassType_Configuration());
            modelBuilder.ApplyConfiguration(new HotelHostelType_Configuration());
            modelBuilder.ApplyConfiguration(new HotelType_Configuration());
            modelBuilder.ApplyConfiguration(new IntegratorSystem_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceOptionType_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceTransactionType_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceType_Configuration());
            modelBuilder.ApplyConfiguration(new LanguageType_Configuration());
            modelBuilder.ApplyConfiguration(new ModuleType_Configuration());
            modelBuilder.ApplyConfiguration(new MonthType_Configuration());
            modelBuilder.ApplyConfiguration(new PassengerType_Configuration());
            modelBuilder.ApplyConfiguration(new PassportType_Configuration());
            modelBuilder.ApplyConfiguration(new PayerType_Configuration());
            modelBuilder.ApplyConfiguration(new PaymentTermType_Configuration());
            modelBuilder.ApplyConfiguration(new PaymentType_Configuration());
            modelBuilder.ApplyConfiguration(new RegionType_Configuration());
            modelBuilder.ApplyConfiguration(new ReportOptionType_Configuration());
            modelBuilder.ApplyConfiguration(new RoleDate_Configuration());
            modelBuilder.ApplyConfiguration(new SendInfoType_Configuration());
            modelBuilder.ApplyConfiguration(new ShipCabinType_Configuration());
            modelBuilder.ApplyConfiguration(new SourceType_Configuration());
            modelBuilder.ApplyConfiguration(new SpecialCodeType_Configuration());
            modelBuilder.ApplyConfiguration(new SystemUIElements_Configuration());
            modelBuilder.ApplyConfiguration(new TitleType_Configuration());
            modelBuilder.ApplyConfiguration(new TransactionGroup_Configuration());
            modelBuilder.ApplyConfiguration(new UnitCodeType_Configuration());
            modelBuilder.ApplyConfiguration(new VisaType_Configuration());
            modelBuilder.ApplyConfiguration(new WorkerType_Configuration());
            modelBuilder.ApplyConfiguration(new Continent_Configuration());
            modelBuilder.ApplyConfiguration(new Currency_Configuration());
            modelBuilder.ApplyConfiguration(new CurrencyRateType_Configuration());
            modelBuilder.ApplyConfiguration(new Client_Configuration());
            modelBuilder.ApplyConfiguration(new ClientUser_Configuration());
            modelBuilder.ApplyConfiguration(new Country_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerType_Configuration());
            modelBuilder.ApplyConfiguration(new District_Configuration());
            modelBuilder.ApplyConfiguration(new Language_Configuration());
            modelBuilder.ApplyConfiguration(new Navigation_Configuration());
            modelBuilder.ApplyConfiguration(new NavigationTranslation_Configuration());
            modelBuilder.ApplyConfiguration(new SystemMessages_Configuration());
            modelBuilder.ApplyConfiguration(new SystemMessagesTranslation_Configuration());

            //***** özkan yaptı 

            modelBuilder.ApplyConfiguration(new HostelTypeSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new RoomTypeSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new ReservationStatusSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new LocationSelectListView_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceGroupSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceTypeSelectView_Configuration());



        }
    }
}
