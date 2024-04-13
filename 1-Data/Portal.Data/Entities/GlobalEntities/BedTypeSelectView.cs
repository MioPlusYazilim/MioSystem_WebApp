using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class BedTypeSelectView : BaseEntity
    {
        public BedTypeSelectView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }

    /*EntityMap Oluştur*/
    public class BedTypeSelectView_Configuration : IEntityTypeConfiguration<BedTypeSelectView>
    {
        public void Configure(EntityTypeBuilder<BedTypeSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("BedTypeSelectView");
            // Navigate Properties
        }
    }
}
