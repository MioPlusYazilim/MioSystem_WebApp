using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class Country : BaseEntity
    {
        public Country()
        {
        }

        public int ContinentID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Country_Configuration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ContinentID).HasColumnName("ContinentID").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("Country");
            // Navigate Properties
        }
    }
}
