using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerCreditLimit : BaseEntity
    {
        public CustomerCreditLimit()
        {
        }

        public int CustomerID { get; set; }
        public int ModuleID { get; set; }
        public int CurrencyID { get; set; }
        public double CreditLimit { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerCreditLimit_Configuration : IEntityTypeConfiguration<CustomerCreditLimit>
    {
        public void Configure(EntityTypeBuilder<CustomerCreditLimit> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerCreditLimit");
            // Navigate Properties
        }
    }
}
