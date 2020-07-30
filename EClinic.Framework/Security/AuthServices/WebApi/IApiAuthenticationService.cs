using EClinic.Framework.DependencyInjection;

namespace EClinic.Framework.Security
{
    public interface IApiAuthenticationService: IDependency
    {
        bool IsAuthenticated(TokenRequest tokenRequest, out string token);
    }
}