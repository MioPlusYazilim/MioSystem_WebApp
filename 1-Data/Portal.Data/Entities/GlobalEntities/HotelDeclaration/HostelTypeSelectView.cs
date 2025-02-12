using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class HostelTypeSelectView : BaseEntity
    {
        public HostelTypeSelectView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }

    /*EntityMap Oluştur*/
    public class HostelTypeSelectView_Configuration : IEntityTypeConfiguration<HostelTypeSelectView>
    {
        public void Configure(EntityTypeBuilder<HostelTypeSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("HostelTypeSelectView");
            // Navigate Properties
        }
    }
}