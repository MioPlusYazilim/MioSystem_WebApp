using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class SystemMessagesTranslation : BaseEntity
    {
        public SystemMessagesTranslation()
        {
        }
        public int ParentID { get; set; }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SystemMessagesTranslation_Configuration : IEntityTypeConfiguration<SystemMessagesTranslation>
    {
        public void Configure(EntityTypeBuilder<SystemMessagesTranslation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.ToTable("SystemMessagesTranslation");
            // Navigate Properties
        }
    }
}