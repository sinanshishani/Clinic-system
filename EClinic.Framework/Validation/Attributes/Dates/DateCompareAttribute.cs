using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace EClinic.Framework.Validation.Attributes
{
    public enum DateTimeCampare
    {
        Less,
        LessOrEqual,
        Greater,
        GreaterOrEqual
    }


    public class DateCompareAttribute : ValidationAttribute
    {
        private string otherPropertyName;
        private DateTimeCampare dateTimeCampare;

        public DateCompareAttribute(string otherPropertyName, DateTimeCampare dateTimeCampare)
        {
            this.otherPropertyName = otherPropertyName;
            this.dateTimeCampare = dateTimeCampare;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;

            // Using reflection we can get a reference to the other date property, in this example the project start date
            Type containerType = validationContext.ObjectInstance.GetType();
            PropertyInfo otherProperty = containerType.GetProperty(otherPropertyName);

            if (otherProperty == null)
                return new ValidationResult($"Unknown property: {otherPropertyName}.");

            object otherPropertyValue = otherProperty.GetValue(validationContext.ObjectInstance, null);

            if (otherPropertyValue == null)
                return validationResult;

            // Let's check that otherProperty is of type DateTime as we expect it to be
            if (otherProperty.PropertyType == typeof(DateTime) || (otherProperty.PropertyType.IsGenericType && otherProperty.PropertyType == typeof(DateTime?)))
            {
                DateTime toValidate = (DateTime)value;
                DateTime referencePropertyValue = (DateTime)otherPropertyValue;

                // if the end date is lower than the start date, than the validationResult will be set to false and return
                // a properly formatted error message
                switch (dateTimeCampare)
                {
                    case DateTimeCampare.Less:
                        if (toValidate >= referencePropertyValue) validationResult = new ValidationResult(ErrorMessageString);
                        break;
                    case DateTimeCampare.LessOrEqual:
                        if (toValidate > referencePropertyValue) validationResult = new ValidationResult(ErrorMessageString);
                        break;
                    case DateTimeCampare.Greater:
                        if (toValidate <= referencePropertyValue) validationResult = new ValidationResult(ErrorMessageString);
                        break;
                    case DateTimeCampare.GreaterOrEqual:
                        if (toValidate < referencePropertyValue) validationResult = new ValidationResult(ErrorMessageString);
                        break;
                    default:
                        break;
                }
            }
            else
                validationResult = new ValidationResult("An error occurred while validating the property. OtherProperty is not of type DateTime");

            return validationResult;
        }
    }
}