using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class CustomerType : BaseEntity
    {
        public CustomerType()
        {
        }

    }

    /*EntityMap Oluştur*/
    public class CustomerType_Configuration : IEntityTypeConfiguration<CustomerType>
    {
        public void Configure(EntityTypeBuilder<CustomerType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerType");
            // Navigate Properties
        }
    }
}
