using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerSelectView : BaseEntity
    {
        public CustomerSelectView()
        {
        }

        public string Code { get; set; }
        public string CodeName { get; set; }
        public string FullName { get; set; }
        public int GroupID { get; set; }
        public int TypeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerSelectView_Configuration : IEntityTypeConfiguration<CustomerSelectView>
    {
        public void Configure(EntityTypeBuilder<CustomerSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerSelectView");
            // Navigate Properties
        }
    }
}
