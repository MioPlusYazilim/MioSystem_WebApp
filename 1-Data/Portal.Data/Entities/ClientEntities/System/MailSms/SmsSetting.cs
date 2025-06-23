using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class SmsSetting : BaseEntity
    {
        public SmsSetting()
        {
        }

        public string ServiceNo { get; set; }
        public string ServiceUser { get; set; }
        public string ServicePassword { get; set; }
        public string ServiceTitle { get; set; }
        public int ServiceLimit { get; set; }
        public int SourceID { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SmsSetting_Configuration : IEntityTypeConfiguration<SmsSetting>
    {
        public void Configure(EntityTypeBuilder<SmsSetting> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("SmsSetting");
            // Navigate Properties
        }
    }
}