using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerUrnAddress : BaseEntity
    {
        public CustomerUrnAddress()
        {
        }

        public int CustomerID { get; set; }
        public string UrnAddress { get; set; }
        public bool IsActive { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerUrnAddress_Configuration : IEntityTypeConfiguration<CustomerUrnAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerUrnAddress> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerUrnAddress");
            // Navigate Properties
        }
    }
}

