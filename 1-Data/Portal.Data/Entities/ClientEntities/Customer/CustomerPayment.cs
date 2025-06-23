using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerPayment : BaseEntity
    {
        public CustomerPayment()
        {
        }

        public int CustomerID { get; set; }
        public int PaymentTypeID { get; set; }
        public string ModuleIDs { get; set; }
        public bool IsActive { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerPayment_Configuration : IEntityTypeConfiguration<CustomerPayment>
    {
        public void Configure(EntityTypeBuilder<CustomerPayment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerPayment");
            // Navigate Properties
        }
    }
}

