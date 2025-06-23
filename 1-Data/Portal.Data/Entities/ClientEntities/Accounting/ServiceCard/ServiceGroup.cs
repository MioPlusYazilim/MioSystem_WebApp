using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class ServiceGroup : BaseEntity
    {
        public ServiceGroup()
        {
        }

        public int? ParentID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ServiceGroup_Configuration : IEntityTypeConfiguration<ServiceGroup>
    {
        public void Configure(EntityTypeBuilder<ServiceGroup> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("ServiceGroup");
            // Navigate Properties
        }
    }
}

