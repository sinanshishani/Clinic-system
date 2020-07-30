using System;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Framework.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StringNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is string))
                throw new ValidationException("Property type is not a string");

            if (value == null)
                return ValidationResult.Success;

            if (string.IsNullOrEmpty(value.ToString().Trim()))
                return ValidationResult.Success;

            long longVal;
            string errorMassage = "String value is not a number";

            if (!long.TryParse(value.ToString(), out longVal))
                return new ValidationResult(errorMassage);

            return ValidationResult.Success;
        }
    }
}