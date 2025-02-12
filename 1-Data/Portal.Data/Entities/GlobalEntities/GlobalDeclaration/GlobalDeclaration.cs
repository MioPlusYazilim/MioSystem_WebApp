using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class GlobalDeclaration : BaseEntity
    {
        public GlobalDeclaration()
        {
        }

        public int KeyID { get; set; }
        public int FieldType { get; set; }
    }

    /*EntityMap Oluştur*/
    public class GlobalDeclaration_Configuration : IEntityTypeConfiguration<GlobalDeclaration>
    {
        public void Configure(EntityTypeBuilder<GlobalDeclaration> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("GlobalDeclaration");
            // Navigate Properties
        }
    }
}
