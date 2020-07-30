using Abp.Reflection.Extensions;
using EClinic.Framework.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EClinic.Repository.Context
{
    public class EClinicDbContext : ApplicationDbContext
    {
        public EClinicDbContext(IEnumerable<IDbContextEntitiesProvider> entitiesProviders) 
            : base(entitiesProviders)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EClinicDbContext).GetAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}