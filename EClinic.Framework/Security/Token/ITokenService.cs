using System.Collections.Generic;
using System.Security.Claims;
using EClinic.Framework.DependencyInjection;

namespace EClinic.Framework.Security
{
    public interface ITokenService: IDependency
    {
        string SecretKey { get; set; }

        bool IsTokenValid(string token);
        string GenerateToken(IAuthContainerModel model);
        IEnumerable<Claim> GetTokenClaims(string token);
    }
}
