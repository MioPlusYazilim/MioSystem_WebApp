using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionComment : BaseEntity
    {
        public TransactionComment()
        {
        }

        public int? ParentID { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentTypeID { get; set; }
        public string CommentNote { get; set; }
        public bool IsHidden { get; set; }
        public int EmployeeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionComment_Configuration : IEntityTypeConfiguration<TransactionComment>
    {
        public void Configure(EntityTypeBuilder<TransactionComment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionComment");
            // Navigate Properties
        }
    }
}

