using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class PassportType : BaseEntity
    {
        public PassportType()
        {
        }

    }

    /*EntityMap Oluştur*/
    public class PassportType_Configuration : IEntityTypeConfiguration<PassportType>
    {
        public void Configure(EntityTypeBuilder<PassportType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("PassportType");
            // Navigate Properties
        }
    }
}
