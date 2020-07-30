using System.Security.Claims;

namespace EClinic.Framework.Security
{
    public interface IAuthContainerModel
    {
        string SecurityAlgorithm { get; }
        int ExpireMinutes { get; set; }

        Claim[] Claims { get; set; }
    }
}