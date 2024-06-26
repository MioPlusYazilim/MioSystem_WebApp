using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class SendInfoTypeTranslation : BaseEntity
    {
        public SendInfoTypeTranslation()
        {
        }

        public int ParentID { get; set; }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SendInfoTypeTranslation_Configuration : IEntityTypeConfiguration<SendInfoTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<SendInfoTypeTranslation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("SendInfoTypeTranslation");
            // Navigate Properties
        }
    }
}
