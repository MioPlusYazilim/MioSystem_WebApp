using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class SpecialCodeSelectView : BaseEntity
    {
        public SpecialCodeSelectView()
        {
        }

        public int TypeID { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SpecialCodeSelectView_Configuration : IEntityTypeConfiguration<SpecialCodeSelectView>
    {
        public void Configure(EntityTypeBuilder<SpecialCodeSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("SpecialCodeSelectView");
            // Navigate Properties
        }
    }
}
