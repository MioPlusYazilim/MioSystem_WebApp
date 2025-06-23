using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class PaymentTermGroup : BaseEntity
    {
        public PaymentTermGroup()
        {
        }

        public string Code { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class PaymentTermGroup_Configuration : IEntityTypeConfiguration<PaymentTermGroup>
    {
        public void Configure(EntityTypeBuilder<PaymentTermGroup> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("PaymentTermGroup");
            // Navigate Properties
        }
    }
}
