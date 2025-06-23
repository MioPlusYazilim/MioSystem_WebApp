using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Data.Entities;

namespace Portal.Api.Data.Entity
{
    public class CommentType : BaseEntity
    {
        public CommentType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldCode { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CommentType_Configuration : IEntityTypeConfiguration<CommentType>
    {
        public void Configure(EntityTypeBuilder<CommentType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CommentType");
            // Navigate Properties
        }
    }
}
