﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class SpecialCode : BaseEntity
    {
        public SpecialCode()
        {
        }

        public int SpecialCodeTypeID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public int CustomerID { get; set; }
        public int CustomerGroupID { get; set; }
        public string ModulesIDs { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SpecialCode_Configuration : IEntityTypeConfiguration<SpecialCode>
    {
        public void Configure(EntityTypeBuilder<SpecialCode> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("SpecialCode");
            // Navigate Properties
        }
    }
}

