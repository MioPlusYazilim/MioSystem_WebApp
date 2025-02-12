using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class ExceptionType : BaseEntity
    {
        public ExceptionType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ExceptionType_Configuration : IEntityTypeConfiguration<ExceptionType>
    {
        public void Configure(EntityTypeBuilder<ExceptionType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("ExceptionType");
            // Navigate Properties
        }
    }
}
