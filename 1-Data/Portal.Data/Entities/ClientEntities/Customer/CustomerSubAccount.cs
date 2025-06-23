using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerSubAccount : BaseEntity
    {
        public CustomerSubAccount()
        {
        }

        public int CustomerID { get; set; }
        public int SubCustomerID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerSubAccount_Configuration : IEntityTypeConfiguration<CustomerSubAccount>
    {
        public void Configure(EntityTypeBuilder<CustomerSubAccount> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerSubAccount");
            // Navigate Properties
        }
    }
}

