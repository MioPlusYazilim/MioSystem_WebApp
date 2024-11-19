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

            builder.ToTable("ClientUser");
            // Navigate Properties
        }
    }
}
