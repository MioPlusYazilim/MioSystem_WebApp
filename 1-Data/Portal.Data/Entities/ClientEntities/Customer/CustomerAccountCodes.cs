using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerAccountCodes : BaseEntity
    {
        public CustomerAccountCodes()
        {
        }

        public int CustomerID { get; set; }
        public int InvoiceTransactionTypeID { get; set; }
        public string AccountingGroup { get; set; }
        public string AccountingCode { get; set; }
        public string ExceptionCode { get; set; }
        public string VatCode { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerAccountCodes_Configuration : IEntityTypeConfiguration<CustomerAccountCodes>
    {
        public void Configure(EntityTypeBuilder<CustomerAccountCodes> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerAccountCodes");
            // Navigate Properties
        }
    }
}
