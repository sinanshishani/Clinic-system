using System;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Framework.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IntegerLengthAttribute : ValidationAttribute
    {
        private int length;

        public IntegerLengthAttribute(int length)
        {
            this.length = length;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            if (!value.IsNumber())
                throw new ValidationException("Property type is not a number type");

            int intVal = (int)value;

            int min = (int)Math.Pow(10, length - 1);
            int max = (int)Math.Pow(10, length) - 1;


            if (min <= intVal || intVal <= max)
                return new ValidationResult(ErrorMessage);

            return ValidationResult.Success;
        }
    }
}
