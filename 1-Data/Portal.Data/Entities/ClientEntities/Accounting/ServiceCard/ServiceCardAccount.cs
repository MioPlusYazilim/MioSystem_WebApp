using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class ServiceCardAccount : BaseEntity
    {
        public ServiceCardAccount()
        {
        }

        public int ServiceCardID { get; set; }
        public int TransactionTypeID { get; set; }
        public int TransactionGroupID { get; set; }
        public string AccountGroup { get; set; }
        public int ModuleID { get; set; }
        public string AccountCode { get; set; }
        public string AccountTaxCode { get; set; }
        public string AccountExempCode { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ServiceCardAccount_Configuration : IEntityTypeConfiguration<ServiceCardAccount>
    {
        public void Configure(EntityTypeBuilder<ServiceCardAccount> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("ServiceCardAccount");
            // Navigate Properties
        }
    }
}

