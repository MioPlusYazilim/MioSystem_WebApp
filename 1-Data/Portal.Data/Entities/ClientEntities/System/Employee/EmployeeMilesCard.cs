using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeMilesCard : BaseEntity
    {
        public EmployeeMilesCard()
        {
        }

        public string MilesCardNo { get; set; }
        public string MilesCardDate { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeeMilesCard_Configuration : IEntityTypeConfiguration<EmployeeMilesCard>
    {
        public void Configure(EntityTypeBuilder<EmployeeMilesCard> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeeMilesCard");
            // Navigate Properties
        }
    }
}

