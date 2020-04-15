using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Utilities {
    public class NoZNamesAttribute : ValidationAttribute {
        protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
            if (value == null) {
                return ValidationResult.Success;
            }
            string valueofstring = (string) value;

            if (valueofstring.Length < 20)
                return new ValidationResult ("Comments Must be atleast 20 characters long!");
            return ValidationResult.Success;
        }
    }
}