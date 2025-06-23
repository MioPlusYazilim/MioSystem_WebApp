using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerAutoService : BaseEntity
    {
        public CustomerAutoService()
        {
        }

        public int CustomerID { get; set; }
        public int AutoServiceTypeID { get; set; }
        public string ModuleIDs { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerAutoService_Configuration : IEntityTypeConfiguration<CustomerAutoService>
    {
        public void Configure(EntityTypeBuilder<CustomerAutoService> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerAutoService");
            // Navigate Properties
        }
    }
}

