﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class SendInfoType : BaseEntity
    {
        public SendInfoType()
        {
        }

    }

    /*EntityMap Oluştur*/
    public class SendInfoType_Configuration : IEntityTypeConfiguration<SendInfoType>
    {
        public void Configure(EntityTypeBuilder<SendInfoType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("SendInfoType");
            // Navigate Properties
        }
    }
}