using Abp.Specifications;
using System;
using System.Linq.Expressions;

namespace EClinic.Domain.Lookups
{
    public class SystemSurgeryNameSpecification : Specification<SystemSurgery>
    {
        public SystemSurgeryNameSpecification(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override Expression<Func<SystemSurgery, bool>> ToExpression()
        {
            return (surgery) => (surgery.Name.ToLower() == Name.ToLower());
        }
    }
}