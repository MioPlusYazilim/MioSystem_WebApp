using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class ReservationStatusSelectView : BaseEntity
    {
        public ReservationStatusSelectView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ReservationStatusSelectView_Configuration : IEntityTypeConfiguration<ReservationStatusSelectView>
    {
        public void Configure(EntityTypeBuilder<ReservationStatusSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("ReservationStatusSelectView");
            // Navigate Properties
        }
    }
}