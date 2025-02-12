using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class InvoiceTypeSelectView : BaseEntity
    {
        public InvoiceTypeSelectView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceTypeSelectView_Configuration : IEntityTypeConfiguration<InvoiceTypeSelectView>
    {
        public void Configure(EntityTypeBuilder<InvoiceTypeSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.ToTable("InvoiceTypeSelectView");
            // Navigate Properties
        }
    }
}