using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class AccountingSystem : BaseEntity
    {
        public AccountingSystem()
        {
        }

        public string Code { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AccountingSystem_Configuration : IEntityTypeConfiguration<AccountingSystem>
    {
        public void Configure(EntityTypeBuilder<AccountingSystem> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();


            builder.Ignore(i => i.Deleted);
            builder.ToTable("AccountingSystem");
            // Navigate Properties
        }
    }
}