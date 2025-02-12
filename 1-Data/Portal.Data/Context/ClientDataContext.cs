using Microsoft.EntityFrameworkCore;
using Portal.Data.Entities.ClientEntities;

namespace Portal.Data.Context
{
    public class ClientDataContext : DbContext
    {

        private string ClientConnStr { get; set; } = string.Empty;
        
        public ClientDataContext(string ConnStr)
        {
            ClientConnStr = ConnStr;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ClientConnStr);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyGetInfoView> CompanyGetInfoViews { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAuthorization> EmployeeAuthorizations { get; set; }
        public DbSet<EmployeeSystemCode> EmployeeSystemCodes { get; set; }
        public DbSet<EmployeeSelectView> EmployeeSelectViews { get; set; }
        public DbSet<Department> Departments { get; set; }




        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerSelectView> CustomerSelectViews { get; set; }
        public DbSet<CustomerProjectSelectView> CustomerProjectSelectViews { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public DbSet<CustomerGroupSelectView> CustomerGroupSelectViews { get; set; }
        public DbSet<CustomerCorporate> CustomerCorporates { get; set; }
        public DbSet<CustomerCorporateSelectView> CustomerCorporateSelectViews { get; set; }

        public DbSet<RoleAuthory> RoleAuthories { get; set; }
        public DbSet<RoleAuthoryPermission> RoleAuthoryPermissions { get; set; }

        public DbSet<TransactionStatus> transactionStatuses { get; set; }
        public DbSet<TransactionStatusSelectView> TransactionStatusSelectViews { get; set; }

        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionSelectView> PositionSelectViews { get; set; }
        public DbSet<SpecialCode> SpecialCodes { get; set; }
        public DbSet<SpecialCodeSelectView> SpecialCodeSelectViews { get; set; }
        public DbSet<SupplierChain> SupplierChains { get; set; }

        public DbSet<FlightTicketWebReportView> FlightTicketWebReportViews { get; set; }
        public DbSet<HotelWebReportView> HotelWebReportViews { get; set; }
        public DbSet<InvoiceWebReportView> InvoiceWebReportViews { get; set; }
        public DbSet<ModulWebReportView> ModulWebReportViews { get; set; }

        public DbSet<InvoiceCheckView> InvoiceCheckViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Company_Configuration());
            modelBuilder.ApplyConfiguration(new CompanyGetInfoView_Configuration());
            modelBuilder.ApplyConfiguration(new Employee_Configuration());
            modelBuilder.ApplyConfiguration(new EmployeeAuthorization_Configuration());
            modelBuilder.ApplyConfiguration(new EmployeeSystemCode_Configuration());
            modelBuilder.ApplyConfiguration(new Department_Configuration());

            modelBuilder.ApplyConfiguration(new EmployeeSelectView_Configuration());

            modelBuilder.ApplyConfiguration(new Customer_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerProjectSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerGroup_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerGroupSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerCorporate_Configuration());
            modelBuilder.ApplyConfiguration(new CustomerCorporateSelectView_Configuration());



            modelBuilder.ApplyConfiguration(new Role_Configuration());
            modelBuilder.ApplyConfiguration(new RoleAuthory_Configuration());

            modelBuilder.ApplyConfiguration(new TransactionStatus_Configuration());
            modelBuilder.ApplyConfiguration(new TransactionStatusSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new Position_Configuration());
            modelBuilder.ApplyConfiguration(new PositionSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new SpecialCode_Configuration());
            modelBuilder.ApplyConfiguration(new SpecialCodeSelectView_Configuration());
            modelBuilder.ApplyConfiguration(new SupplierChain_Configuration());
            
            modelBuilder.ApplyConfiguration(new FlightTicketWebReportView_Configuration());
            modelBuilder.ApplyConfiguration(new HotelWebReportView_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceWebReportView_Configuration());
            modelBuilder.ApplyConfiguration(new ModulWebReportView_Configuration());
            modelBuilder.ApplyConfiguration(new InvoiceCheckView_Configuration());

        }
    }
}
