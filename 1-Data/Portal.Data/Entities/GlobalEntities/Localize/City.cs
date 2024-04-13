using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class City : BaseEntity
    {
        public City()
        {
        }

        public int CountryID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class City_Configuration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.CountryID).HasColumnName("CountryID").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("City");
            // Navigate Properties
        }
    }
}
