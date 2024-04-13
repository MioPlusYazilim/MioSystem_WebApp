using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class PositionSelectView : BaseEntity
    {
        public PositionSelectView()
        {
        }

        public string Code { get; set; }
        public string FullName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class PositionSelectView_Configuration : IEntityTypeConfiguration<PositionSelectView>
    {
        public void Configure(EntityTypeBuilder<PositionSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("PositionSelectView");
            // Navigate Properties
        }
    }
}