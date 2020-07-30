using Abp.Application.Services;
using EClinic.AppDomain.Lookups;

namespace EClinic.AppServices.Lookups
{
    public partial class SystemLookupsService : ApplicationService, ISystemLookupsService
    {
        private readonly ISystemLookupsManager _systemtLookupsManager;

        public SystemLookupsService(ISystemLookupsManager systemtLookupsManager)
        {
            _systemtLookupsManager = systemtLookupsManager;
        }

    }
}
