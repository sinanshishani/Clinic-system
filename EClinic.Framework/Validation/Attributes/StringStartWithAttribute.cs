using Microsoft.Extensions.Primitives;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EClinic.Framework.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StringStartWithAttribute : ValidationAttribute
    {
        private string _startWith;

        public StringStartWithAttribute(string startWith)
        {
            _startWith = startWith;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is string))
                throw new ValidationException("Property type is not a string");

            if (string.IsNullOrEmpty(value?.ToString()))
                return ValidationResult.Success;

            if (value.ToString().StartsWithIgnoreCase(_startWith))
                return ValidationResult.Success;

            return new ValidationResult(ErrorMessage);
        }
    }
}