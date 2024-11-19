using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            employeeAuthorizations = new EmployeeAuthorization();
            employeeSystemCodes = new List<EmployeeSystemCode>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LongName { get; set; }
        public string Email { get; set; }
        public string GSMNumber { get; set; }
        public int CustomerID { get; set; }
        public string ModulIDs { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }

        public virtual EmployeeAuthorization employeeAuthorizations { get; set; }
        public virtual List<EmployeeSystemCode> employeeSystemCodes { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Employee_Configuration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.FirstName).HasColumnName("FirstName").HasMaxLength(100);
            builder.Property(t => t.LastName).HasColumnName("LastName").HasMaxLength(100);
            builder.Property(t => t.LongName).HasColumnName("LongName").ValueGeneratedOnAddOrUpdate().IsRequired().HasMaxLength(201);
            builder.Property(t => t.Email).HasColumnName("Email").HasMaxLength(100);
            builder.Property(t => t.GSMNumber).HasColumnName("GSMNumber").HasMaxLength(20);
            builder.Property(t => t.CustomerID).HasColumnName("CustomerID").IsRequired();
            builder.Property(t => t.ModulIDs).HasColumnName("ModulIDs").HasMaxLength(50);
            builder.Property(t => t.CompanyID).HasColumnName("CompanyID").IsRequired();
            builder.Property(t => t.FState).HasColumnName("FState").IsRequired();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.ToTable("Employee");
            // Navigate Properties
            builder.HasOne(s => s.employeeAuthorizations).WithOne(ad => ad.employee).HasForeignKey<EmployeeAuthorization>(fk => fk.EmployeeID).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(s => s.employeeSystemCodes).WithOne(ad => ad.employee).HasForeignKey(fk => fk.EmployeeID).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
