using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class ClientUser
    {
        public string UserName { get; set; }
        public string UserPass{get; set; }
        public string EMail { get; set; }
        public bool Active { get; set; }
        public int EmployeeID { get; set; }
        public string ClientKey { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpireDate { get; set; }
        public string? ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordTokenExpireDate { get; set; }




    }
    public class ClientUser_Configuration : IEntityTypeConfiguration<ClientUser>
    {
        public void Configure(EntityTypeBuilder<ClientUser> builder)
        {
            // Primary Key
            builder.HasKey(t => t.UserName);

            // Properties, Table & Column Mappings
            builder.Property(t => t.UserName).HasColumnName("UserName").IsRequired();
            builder.Property(t => t.UserPass).HasColumnName("UserPass").IsRequired();
            builder.Property(t => t.EMail).HasColumnName("EMail").IsRequired();
            builder.Property(t => t.Active).HasColumnName("Active").IsRequired();
            builder.Property(t => t.EmployeeID).HasColumnName("EmployeeID").IsRequired();
            builder.Property(t => t.ClientKey).HasColumnName("ClientKey").IsRequired();
            builder.Property(t => t.RefreshToken).HasColumnName("RefreshToken");
            builder.Property(t => t.RefreshTokenExpireDate).HasColumnName("RefreshTokenExpireDate");
            builder.Property(t => t.ResetPasswordToken).HasColumnName("ResetPasswordToken");
            builder.Property(t => t.ResetPasswordTokenExpireDate).HasColumnName("ResetPasswordTokenExpireDate");



            builder.ToTable("ClientUser");
            // Navigate Properties
        }
    }
}
