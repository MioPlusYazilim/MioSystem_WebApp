using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TravelPolicy : BaseEntity
    {
        public TravelPolicy()
        {
        }

        public string FieldValue { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TravelPolicy_Configuration : IEntityTypeConfiguration<TravelPolicy>
    {
        public void Configure(EntityTypeBuilder<TravelPolicy> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TravelPolicy");
            // Navigate Properties
        }
    }
}
