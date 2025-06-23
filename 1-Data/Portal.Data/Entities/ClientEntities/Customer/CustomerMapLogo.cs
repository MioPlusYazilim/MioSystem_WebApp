using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerMapLogo : BaseEntity
    {
        public CustomerMapLogo()
        {
        }

        public int CustomerID { get; set; }
        public string Map { get; set; }
        public string LogoLink { get; set; }
        public byte[] Logo { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerMapLogo_Configuration : IEntityTypeConfiguration<CustomerMapLogo>
    {
        public void Configure(EntityTypeBuilder<CustomerMapLogo> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerMapLogo");
            // Navigate Properties
        }
    }
}

