using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class LocationSelectListView : BaseEntity
    {
        public LocationSelectListView()
        {
        }

        public string Name { get; set; }
        public string FullName { get; set; }
        public int TypeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class LocationSelectListView_Configuration : IEntityTypeConfiguration<LocationSelectListView>
    {
        public void Configure(EntityTypeBuilder<LocationSelectListView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.ToTable("LocationSelectListView");
            // Navigate Properties
        }
    }
}


