using System;
using System.Collections.Generic;
using EClinic.Framework.DependencyInjection;

namespace EClinic.Framework.Data
{
    public interface IDbContextEntitiesProvider : IDependency
    {
        IEnumerable<Type> GetEntities();
    }
}