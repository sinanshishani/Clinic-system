using System;
using System.Collections.Generic;
using System.Linq;
using EClinic.Framework.Configurations;
using EClinic.Framework.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace EClinic.Framework.Data
{
    public abstract class ApplicationDbContext : DbContext, IDependency
    {
        private readonly IEnumerable<IDbContextEntitiesProvider> entitiesProviders;

        public ApplicationDbContext(IEnumerable<IDbContextEntitiesProvider> entitiesProviders)
        {
            this.entitiesProviders = entitiesProviders;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfigs.Instance.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entitiesType in entitiesProviders.SelectMany(x => x.GetEntities()))
            {
                modelBuilder.Entity(entitiesType);
            }
        }


        public override int SaveChanges()
        {
            //var entries = ChangeTracker
            //    .Entries()
            //    .Where(e => e.Entity is DbEntity && (
            //            e.State == EntityState.Added
            //            || e.State == EntityState.Modified));

            //foreach (var entityEntry in entries)
            //{
            //    ((DbEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

            //    if (entityEntry.State == EntityState.Added)
            //    {
            //        ((DbEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
            //    }
            //}

            return base.SaveChanges();
        }
    }
}
