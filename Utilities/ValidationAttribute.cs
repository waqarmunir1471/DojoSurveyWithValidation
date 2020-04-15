using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Utilities {
    public class FutureDateAttribute : ValidationAttribute {
        protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
            Console.WriteLine("********************"+value); 
            DateTime compare = (DateTime)value;
            if(compare != null){
                if (compare < DateTime.Now) {
                    Console.WriteLine("************************"+value);       
                    return ValidationResult.Success;
                }
                else{
                return new ValidationResult ("Joining Date Must be in Past!");
            }
            }else{
                return new ValidationResult("This is not a Valid Date");
            }
           
        }
    }
}