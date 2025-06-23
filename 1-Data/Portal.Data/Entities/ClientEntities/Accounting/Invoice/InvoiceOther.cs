using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceOther : BaseEntity
    {
        public InvoiceOther()
        {
        }

        public int InvoiceID { get; set; }
        public string Notes { get; set; }
        public string Notes2 { get; set; }
        public string SubCustomerCode { get; set; }
        public string BuyingDocumentNo { get; set; }
        public string SalesDocumentNo { get; set; }
        public string Reference { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderNo { get; set; }
        public string CostCenter { get; set; }
        public string Department { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string UrnAddress { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceOther_Configuration : IEntityTypeConfiguration<InvoiceOther>
    {
        public void Configure(EntityTypeBuilder<InvoiceOther> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceOther");
            // Navigate Properties
        }
    }
}
