using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionPrice : BaseEntity
    {
        public TransactionPrice()
        {
        }

        public int MasterID { get; set; }
        public int ParentID { get; set; }
        public int ModuleID { get; set; }
        public int PriceTypeID { get; set; }
        public int Quantity { get; set; }
        public string CurrencyCode { get; set; }
        public double ExchangeRate { get; set; }
        public double Amount { get; set; }
        public double VatRate { get; set; }
        public bool IsVatIncluded { get; set; }
        public double VatAmount { get; set; }
        public double TotalAmount { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionPrice_Configuration : IEntityTypeConfiguration<TransactionPrice>
    {
        public void Configure(EntityTypeBuilder<TransactionPrice> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionPrice");
            // Navigate Properties
        }
    }
}