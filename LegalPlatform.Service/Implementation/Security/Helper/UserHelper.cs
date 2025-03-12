using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Service.Abstraction.Security;
using GraduationProjectStore.Service.Implementation.Security.Helper;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace GraduationProjectStore.Service.Implementation.Business.Helper
{
    public static class UserHelper
    {
        public async static ValueTask<string> GenerateConfirmationCode
            (LegalUser user, IMailService mail,UserManager<LegalUser> userManager)
        {
            var code = Random.Shared.Next(100000, 999999).ToString();
            var generateResult = await userManager.SetAuthenticationTokenAsync
                (user,"ConfirmationCode","ConfirmationCode",code);

            if (!generateResult.Succeeded)
                return "Invalid Generate Confirmation Code";

            var emailMessage = $@"
                <h1>Hello {user.UserName},</h1>
                <p>Thank you for registering with Legal Ease.</p>
                <p>Your verification code is:</p>
                <h2>{code}</h2>
                <p>If you did not request this, please ignore this email.</p>
                <p>Thank you,<br>Legal Platform Team</p>
            ";

            return await mail.SendMail(user.Email,"Confirmation Code", emailMessage);
        }

        public static object GenerateToken(IConfiguration config, LegalUser client, IEnumerable<string> roles)
        {
            var JwtOptions = config.GetSection("JWT").Get<JWTOptions>();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtOptions!.Key));
            var _credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var _claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Role,string.Join(' ',roles)),
                new Claim(JwtRegisteredClaimNames.Sub,client.UserName!),
                new Claim(JwtRegisteredClaimNames.Name,client.UserName!),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken
            (
               issuer: JwtOptions.Issuer,
               audience: JwtOptions.Audience,
               signingCredentials: _credentials,
               claims: _claims,
               expires: DateTime.Now.AddMinutes(int.Parse(JwtOptions.Expire))
            );

            return new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expire = token.ValidTo
            };
        }
    }
}
