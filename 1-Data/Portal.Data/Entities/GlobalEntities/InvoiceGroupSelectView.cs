using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class InvoiceGroupSelectView : BaseEntity
    {
        public InvoiceGroupSelectView()
        {
        }

        public string Code { get; set; }
        public int TypeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceGroupSelectView_Configuration : IEntityTypeConfiguration<InvoiceGroupSelectView>
    {
        public void Configure(EntityTypeBuilder<InvoiceGroupSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.ToTable("InvoiceGroupSelectView");
            // Navigate Properties
        }
    }
}