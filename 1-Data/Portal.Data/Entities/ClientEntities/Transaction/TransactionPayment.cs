using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionPayment : BaseEntity
    {
        public TransactionPayment()
        {
        }

        public int ParentID { get; set; }
        public int DetailID { get; set; }
        public int PaymentDirectionID { get; set; }
        public int PaymentTypeID { get; set; }
        public DateTime PaymentTermDate { get; set; }
        public int CreditCardID { get; set; }
        public int CreditCardTypeID { get; set; }
        public string CreditCardNumber { get; set; }
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string IBANNumber { get; set; }
        public double TotalAmount { get; set; }
        public int EmployeeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionPayment_Configuration : IEntityTypeConfiguration<TransactionPayment>
    {
        public void Configure(EntityTypeBuilder<TransactionPayment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionPayment");
            // Navigate Properties
        }
    }
}
