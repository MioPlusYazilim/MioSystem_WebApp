using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class DistrictTranslation : BaseEntity
    {
        public DistrictTranslation()
        {
        }

        public int ParentID { get; set; }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class DistrictTranslation_Configuration : IEntityTypeConfiguration<DistrictTranslation>
    {
        public void Configure(EntityTypeBuilder<DistrictTranslation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ParentID).HasColumnName("ParentID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(4);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(100);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("DistrictTranslation");
            // Navigate Properties
        }
    }
}
