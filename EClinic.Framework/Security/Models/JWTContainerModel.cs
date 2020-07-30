using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace EClinic.Framework.Security
{
    public class JWTContainerModel : IAuthContainerModel
    {
        public int ExpireMinutes { get; set; } = 10080; // 7 days.
        public string SecurityAlgorithm => SecurityAlgorithms.HmacSha256Signature;

        public Claim[] Claims { get; set; }
    }
}
