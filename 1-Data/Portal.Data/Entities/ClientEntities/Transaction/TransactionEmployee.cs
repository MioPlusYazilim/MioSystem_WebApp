using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionEmployee : BaseEntity
    {
        public TransactionEmployee()
        {
        }

        public int? ParentID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeMail { get; set; }
        public int EmployeePassportID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionEmployee_Configuration : IEntityTypeConfiguration<TransactionEmployee>
    {
        public void Configure(EntityTypeBuilder<TransactionEmployee> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionEmployee");
            // Navigate Properties
        }
    }
}
