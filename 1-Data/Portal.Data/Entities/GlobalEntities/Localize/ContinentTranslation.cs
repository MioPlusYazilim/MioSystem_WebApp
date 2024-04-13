using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class ContinentTranslation : BaseEntity
    {
        public ContinentTranslation()
        {
        }

        public int ParentID { get; set; }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ContinentTranslation_Configuration : IEntityTypeConfiguration<ContinentTranslation>
    {
        public void Configure(EntityTypeBuilder<ContinentTranslation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ParentID).HasColumnName("ParentID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(5);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(50);
            builder.Property(t => t.FieldName).HasColumnName("FieldName").IsRequired().HasMaxLength(100);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("ContinentTranslation");
            // Navigate Properties
        }
    }
}
