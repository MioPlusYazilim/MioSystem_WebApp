using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class RoomTypeSelectView : BaseEntity
    {
        public RoomTypeSelectView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RoomTypeSelectView_Configuration : IEntityTypeConfiguration<RoomTypeSelectView>
    {
        public void Configure(EntityTypeBuilder<RoomTypeSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("RoomTypeSelectView");
            // Navigate Properties
        }
    }
}