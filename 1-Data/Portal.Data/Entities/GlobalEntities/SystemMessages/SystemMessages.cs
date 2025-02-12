using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class SystemMessages : BaseEntity
    {
        public SystemMessages()
        {
        }
        public string MessageName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SystemMessages_Configuration : IEntityTypeConfiguration<SystemMessages>
    {
        public void Configure(EntityTypeBuilder<SystemMessages> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.ToTable("SystemMessages");
            // Navigate Properties
        }
    }
}