using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerCorporate : BaseEntity
    {
        public CustomerCorporate()
        {
        }

        public int CorporateTypeID { get; set; }
        public bool IsGroup { get; set; }
        public int CustomerID { get; set; }
        public bool IsActive { get; set; }
        public string FieldValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerCorporate_Configuration : IEntityTypeConfiguration<CustomerCorporate>
    {
        public void Configure(EntityTypeBuilder<CustomerCorporate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerCorporate");
            // Navigate Properties
        }
    }
}
