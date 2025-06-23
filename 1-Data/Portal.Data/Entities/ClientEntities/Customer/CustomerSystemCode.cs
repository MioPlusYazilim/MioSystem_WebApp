using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerSystemCode : BaseEntity
    {
        public CustomerSystemCode()
        {
        }

        public int CustomerID { get; set; }
        public string SystemCode { get; set; }
        public int? SourceID { get; set; }
        public int? SupplierID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerSystemCode_Configuration : IEntityTypeConfiguration<CustomerSystemCode>
    {
        public void Configure(EntityTypeBuilder<CustomerSystemCode> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerSystemCode");
            // Navigate Properties
        }
    }
}
