using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class Client
    {
        public string ClientName { get; set; }
        public string ClientKey { get; set; }
        public string ClientValue { get; set; }
    }

    public class Client_Configuration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ClientName);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ClientName).HasColumnName("ClientName").IsRequired();
            builder.Property(t => t.ClientKey).HasColumnName("ClientKey").IsRequired();
            builder.Property(t => t.ClientValue).HasColumnName("ClientValue").IsRequired();
            builder.ToTable("Client");
            // Navigate Properties
        }
    }
}
