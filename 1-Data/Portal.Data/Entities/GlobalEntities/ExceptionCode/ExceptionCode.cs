using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class ExceptionCode : BaseEntity
    {
        public ExceptionCode()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public int ExceptionTypeID { get; set; }
        public int Numerator { get; set; }
        public int DeNumerator { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ExceptionCode_Configuration : IEntityTypeConfiguration<ExceptionCode>
    {
        public void Configure(EntityTypeBuilder<ExceptionCode> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("ExceptionCode");
            // Navigate Properties
        }
    }
}
