using System;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Framework.Validation.Attributes
{
    public class PastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            DateTime date = Convert.ToDateTime(value);
            DateTime today = DateTime.Today;

            string errorMassage = "Date must be less than this moment's DateTime";

            if (date >= today)
                return new ValidationResult(errorMassage);

            return ValidationResult.Success;
        }
    }
}