using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerAutoInstruction : BaseEntity
    {
        public CustomerAutoInstruction()
        {
        }

        public int CustomerID { get; set; }
        public DateTime BeginDate { get; set; }
        public string TransactionStatusIDs { get; set; }
        public bool IsPayment { get; set; }
        public bool IsInvoice { get; set; }
        public bool IsActive { get; set; }
        public int ModuleID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerAutoInstruction_Configuration : IEntityTypeConfiguration<CustomerAutoInstruction>
    {
        public void Configure(EntityTypeBuilder<CustomerAutoInstruction> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerAutoInstruction");
            // Navigate Properties
        }
    }
}
