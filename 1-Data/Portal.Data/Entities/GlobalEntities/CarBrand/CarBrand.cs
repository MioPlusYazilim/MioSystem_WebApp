﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class CarBrand : BaseEntity
    {
        public CarBrand()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CarBrand_Configuration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(5);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(40);
            builder.Property(t => t.FieldName).HasColumnName("FieldName").IsRequired().HasMaxLength(100);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("CarBrand");
            // Navigate Properties
        }
    }
}