using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class GlobalModule : BaseEntity
    {
        public GlobalModule()
        {
        }

        public int GlobalDeclarationID { get; set; }
        public int ModuleID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class GlobalModule_Configuration : IEntityTypeConfiguration<GlobalModule>
    {
        public void Configure(EntityTypeBuilder<GlobalModule> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("GlobalModule");
            // Navigate Properties
        }
    }
}
