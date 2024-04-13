using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class District : BaseEntity
    {
        public District()
        {
        }

        public int CityID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class District_Configuration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.CityID).HasColumnName("CityID").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("District");
            // Navigate Properties
        }
    }
}
