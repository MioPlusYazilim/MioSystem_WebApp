using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class VisaTypeTranslation : BaseEntity
    {
        public VisaTypeTranslation()
        {
        }

        public int ParentID { get; set; }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class VisaTypeTranslation_Configuration : IEntityTypeConfiguration<VisaTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<VisaTypeTranslation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ParentID).HasColumnName("ParentID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(5);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(50);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("VisaTypeTranslation");
            // Navigate Properties
        }
    }
}