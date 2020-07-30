using Abp.Dependency;
using System;
using System.Collections.Generic;

namespace EClinic.Framework.Enums
{
    public interface IEnumerations : ITransientDependency
    {
        List<NameValuePair> GetNameValuePairs<T>();
        string GetEnumDescription(Enum value);
    }
}