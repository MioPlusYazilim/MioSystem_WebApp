using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerProjectSelectView : BaseEntity
    {
        public CustomerProjectSelectView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int GroupID { get; set; }
        public int CustomerID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerProjectSelectView_Configuration : IEntityTypeConfiguration<CustomerProjectSelectView>
    {
        public void Configure(EntityTypeBuilder<CustomerProjectSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerProjectSelectView");
            // Navigate Properties
        }
    }
}