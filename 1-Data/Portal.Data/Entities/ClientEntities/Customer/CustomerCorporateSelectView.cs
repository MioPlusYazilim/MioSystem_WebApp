using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerCorporateSelectView : BaseEntity
    {
        public CustomerCorporateSelectView()
        {
        }

        public int TypeID { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public int CustomerID { get; set; }
        public int CustomerGroupID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerCorporateSelectView_Configuration : IEntityTypeConfiguration<CustomerCorporateSelectView>
    {
        public void Configure(EntityTypeBuilder<CustomerCorporateSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerCorporateSelectView");
            // Navigate Properties
        }
    }
}