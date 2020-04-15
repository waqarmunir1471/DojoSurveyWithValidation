using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Utilities
{
    public class NoZNamesAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        string valueofstring = (string)value;
        if (valueofstring.Length < 20)
            return new ValidationResult("No names that start with Z allowed!");
        return ValidationResult.Success;
    }
}
}