using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Framework.Validation.Attributes
{
    public class CollectionValidationResult : ValidationResult
    {
        public CollectionValidationResult() : base("")
        {
        }
        public IList<ValidationResult> NestedResults { get; set; }
    }
}