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


        public DbSet<RoleAuthory> RoleAuthories { get; set; }
        public DbSet<RoleAuthoryPermission> RoleAuthoryPermissions { get; set; }

        public DbSet<TransactionStatus> transactionStatuses { get; set; }
        public DbSet<TransactionStatusSelectView> TransactionStatusSelectViews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Company_Configuration());
            modelBuilder.ApplyConfiguration(new CompanyGetInfoView_Configuration());
            modelBuilder.ApplyConfiguration(new Employee_Configuration());
            modelBuilder.ApplyConfiguration(new EmployeeAuthorization_Configuration());
            modelBuilder.ApplyConfiguration(new EmployeeSystemCode_Configuration());

            modelBuilder.ApplyConfiguration(new EmployeeSelectView_Configuration());

            modelBuilder.ApplyConfiguration(new Role_Configuration());
            modelBuilder.ApplyConfiguration(new RoleAuthory_Configuration());

            modelBuilder.ApplyConfiguration(new TransactionStatus_Configuration());
            modelBuilder.ApplyConfiguration(new TransactionStatusSelectView_Configuration());

        }
    }
}
