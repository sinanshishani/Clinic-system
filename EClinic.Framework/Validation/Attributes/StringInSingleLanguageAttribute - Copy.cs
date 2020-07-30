using Microsoft.Extensions.Primitives;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EClinic.Framework.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StringInSingleLanguageAttribute : ValidationAttribute
    {
        private const string englishAlphanumericRegex = @"^(?:[a-zA-Z]+)(?:[a-zA-Z _]*)$";
        private const string arabicAlphanumericRegex = @"^(?:[\u0621-\u064A]+)(?:[\u0621-\u064A _]*)$";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is string))
                throw new ValidationException("Property type is not a string");

            if (string.IsNullOrEmpty(value?.ToString()))
                return ValidationResult.Success;

            if (Regex.IsMatch(value.As<string>(), englishAlphanumericRegex))
                return ValidationResult.Success;

            if (Regex.IsMatch(value.As<string>(), arabicAlphanumericRegex))
                return ValidationResult.Success;

            return new ValidationResult(ErrorMessage);
        }
    }
}