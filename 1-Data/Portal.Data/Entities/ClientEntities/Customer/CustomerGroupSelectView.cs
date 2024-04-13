using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerGroupSelectView : BaseEntity
    {
        public CustomerGroupSelectView()
        {
        }

        public int? MasterID { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerGroupSelectView_Configuration : IEntityTypeConfiguration<CustomerGroupSelectView>
    {
        public void Configure(EntityTypeBuilder<CustomerGroupSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerGroupSelectView");
            // Navigate Properties
        }
    }
}