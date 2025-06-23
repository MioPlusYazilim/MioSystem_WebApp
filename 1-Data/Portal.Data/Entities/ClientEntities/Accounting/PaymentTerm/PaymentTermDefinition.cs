using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class PaymentTermDefinition : BaseEntity
    {
        public PaymentTermDefinition()
        {
        }

        public bool IsInternational { get; set; }
        public int InvoiceTransactionTypeID { get; set; }
        public int PaymentTermTypeID { get; set; }
        public int PaymentTermDay { get; set; }
        public int PaymentTermRate { get; set; }
        public string ModuleIDs { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class PaymentTermDefinition_Configuration : IEntityTypeConfiguration<PaymentTermDefinition>
    {
        public void Configure(EntityTypeBuilder<PaymentTermDefinition> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("PaymentTermDefinition");
            // Navigate Properties
        }
    }
}

