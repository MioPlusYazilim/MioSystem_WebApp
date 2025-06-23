using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerBank : BaseEntity
    {
        public CustomerBank()
        {
        }

        public int CustomerID { get; set; }
        public int BankID { get; set; }
        public string BranchCode { get; set; }
        public string AccountCode { get; set; }
        public string IbanNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerBank_Configuration : IEntityTypeConfiguration<CustomerBank>
    {
        public void Configure(EntityTypeBuilder<CustomerBank> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerBank");
            // Navigate Properties
        }
    }
}

