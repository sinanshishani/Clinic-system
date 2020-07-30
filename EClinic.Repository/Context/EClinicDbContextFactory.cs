using EClinic.Domain;
using EClinic.Framework.Data;
using System.Reflection;

namespace EClinic.Repository.Context
{
    public class EClinicDbContextFactory : ApplicationDbContextFactory<EClinicDbContext>
    {
        public override Assembly[] GetAssemblies()
        {
            return new Assembly[] {
                Assembly.GetAssembly(typeof(User))
            };
        }
    }
}