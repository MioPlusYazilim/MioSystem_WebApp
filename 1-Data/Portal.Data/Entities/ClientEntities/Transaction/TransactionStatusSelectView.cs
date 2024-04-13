using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionStatusSelectView : BaseEntity
    {
        public TransactionStatusSelectView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int ModulID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionStatusSelectView_Configuration : IEntityTypeConfiguration<TransactionStatusSelectView>
    {
        public void Configure(EntityTypeBuilder<TransactionStatusSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionStatusSelectView");
            // Navigate Properties
        }
    }
}