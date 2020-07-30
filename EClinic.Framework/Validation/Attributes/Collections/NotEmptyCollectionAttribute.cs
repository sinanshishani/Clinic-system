using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Framework.Validation.Attributes
{
    public class NotEmptyCollectionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Colletion is null");

            IEnumerable enumerable = value.As<IEnumerable>();

            string errorMassage = "Collection length must be more than 0";

            int count = 0;

            foreach (var item in enumerable)
                count++;

            if (count == 0)
                return new ValidationResult(errorMassage);

            return ValidationResult.Success;
        }
    }
}