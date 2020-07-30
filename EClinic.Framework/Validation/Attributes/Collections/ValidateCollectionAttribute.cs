using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Framework.Validation.Attributes
{
    public class ValidateCollectionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Colletion is null");

            var result = new CollectionValidationResult();
            //result.ErrorMessage = string.Format(@"Error occured at {0}", validationContext.DisplayName);

            IEnumerable list = value as IEnumerable;
            if (list == null)
            {
                // Single Object
                var results = new List<ValidationResult>();
                Validator.TryValidateObject(value, validationContext, results, true);
                result.NestedResults = results;

                return result;
            }
            else
            {
                var recursiveResultList = new List<ValidationResult>();

                // List Object
                foreach (var item in list)
                {
                    var nestedItemResult = new List<ValidationResult>();
                    var context = new ValidationContext(item);

                    var nestedParentResult = new CollectionValidationResult();
                    //nestedParentResult.ErrorMessage = string.Format(@"Error occured at {0}", validationContext.DisplayName);

                    Validator.TryValidateObject(item, context, nestedItemResult, true);
                    nestedParentResult.NestedResults = nestedItemResult;
                    if (nestedParentResult.NestedResults.Count > 0)
                        recursiveResultList.Add(nestedParentResult);
                }

                if (recursiveResultList.Count > 0)
                {
                    result.NestedResults = recursiveResultList;
                    return result;
                }

                return ValidationResult.Success;
            }
        }
    }
}