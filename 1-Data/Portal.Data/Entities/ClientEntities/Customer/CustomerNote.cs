using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerNote : BaseEntity
    {
        public CustomerNote()
        {
        }

        public int CustomerID { get; set; }
        public string Note { get; set; }
        public string ModuleIDs { get; set; }
        public bool IsActive { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerNote_Configuration : IEntityTypeConfiguration<CustomerNote>
    {
        public void Configure(EntityTypeBuilder<CustomerNote> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerNote");
            // Navigate Properties
        }
    }
}

