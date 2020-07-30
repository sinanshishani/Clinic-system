using EClinic.AppDomain.Lookups.Models;
using EClinic.Framework.Validation.Attributes;
using System.Collections.Generic;

namespace EClinic.AppDomain.Lookups
{
    public class CreateSurgeryInput : CreateLookupInput
    {
        [NotEmptyCollection]
        public ICollection<long> SurgeriesProceduresIds { get; set; }
    }
}