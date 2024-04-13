using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class VisaType : BaseEntity
    {
        public VisaType()
        {
        }

    }

    /*EntityMap Oluştur*/
    public class VisaType_Configuration : IEntityTypeConfiguration<VisaType>
    {
        public void Configure(EntityTypeBuilder<VisaType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("VisaType");
            // Navigate Properties
        }
    }
}