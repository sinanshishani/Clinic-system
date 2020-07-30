using EClinic.Framework.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EClinic.Framework.Security
{
    class WebApiJwtBearerOptions : IConfigureOptions<JwtBearerOptions>
    {
        public void Configure(JwtBearerOptions options)
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(AppConfigs.Instance.Secret)),
                //ValidateIssuer = true,
                //ValidIssuer = AppConfigs.Instance["Auth0:Issuer"],
                //RequireExpirationTime = true,
                //ValidateLifetime = true,
                //ClockSkew = TimeSpan.Zero,
                //ValidateAudience = false
            };
        }
    }
}