using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class CareerGroup : BaseEntity
    {
        public CareerGroup()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CareerGroup_Configuration : IEntityTypeConfiguration<CareerGroup>
    {
        public void Configure(EntityTypeBuilder<CareerGroup> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("CareerGroup");
            // Navigate Properties
        }
    }
}
