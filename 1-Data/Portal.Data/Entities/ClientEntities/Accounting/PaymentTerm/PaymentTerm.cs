using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class PaymentTerm : BaseEntity
    {
        public PaymentTerm()
        {
        }

        public int PaymentTermGroupID { get; set; }
        public int PaymentTermDefinitionID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class PaymentTerm_Configuration : IEntityTypeConfiguration<PaymentTerm>
    {
        public void Configure(EntityTypeBuilder<PaymentTerm> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("PaymentTerm");
            // Navigate Properties
        }
    }
}

