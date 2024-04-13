using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Portal.Data.Entities.ClientEntities;
using Portal.Helpers;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Portal.Data.Services.Security
{
    public class TokenHandler
    {
        IConfiguration _configuration { get; set; }
        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //Token üretecek metot.
        public SessionToken CreateAccessToken(Employee user,string clientKey)
        {
            SessionToken token = new SessionToken();

            string key = Convert.ToString(_configuration["Token:SecurityKey"]);
            int expiration = Convert.ToInt32(_configuration["Token:ExpirationMinutes"]);

            using (CryptoManager engine = new CryptoManager(""))
                key = engine.Decrypt(key);

            //Security  Key'in simetriğini alıyoruz.
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            //Şifrelenmiş kimliği oluşturuyoruz.
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Oluşturulacak token ayarlarını veriyoruz.
            token.Expiration = DateTime.Now.AddMinutes(expiration);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //  Issuer = _configuration["Token:Issuer"],
                //  Audience = _configuration["Token:Audience"],
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("employeeID", user.ID.ToString()),
                    new Claim("authoryGroup",user.employeeParameters.AuthoryGroup.ToString()),
                    new Claim("authoryLevel",user.employeeParameters.AuthoryLevel.ToString()),
                    new Claim("departmentID",user.employeeParameters.DepartmentID.ToString()),
                    new Claim("clientKey",clientKey),
                    new Claim("customerIDs",user.employeeParameters.AuthorizedCustomerIDs??"0"),
                    new Claim("customerGroupIDs",user.employeeParameters.AuthorizedCustomerGroupIDs??"0"),
                }),
                Expires = token.Expiration,
                SigningCredentials = signingCredentials
            };

            //Token üretiyoruz.
            token.AccessToken = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));

            //Refresh Token üretiyoruz.
            token.RefreshToken = CreateRefreshToken();
            return token;
        }

        //Refresh Token üretecek metot.
        public string CreateRefreshToken()
        {
            byte[] number = new byte[32];
            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
            {
                random.GetBytes(number);
                return Convert.ToBase64String(number);
            }
        }
    }
}

