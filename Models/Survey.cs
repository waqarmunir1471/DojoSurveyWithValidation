using System.ComponentModel.DataAnnotations;
using DojoSurveyWithValidation.Utilities;

namespace DojoSurveyWithValidation.Models
{
    public class Survey
    {
        [Required(ErrorMessage=" Name Must be 2 charactors long")]
        [Display(Name="Your Name : ")]
        public string YourName {get;set;}

        [Required(ErrorMessage=" Select at Least One Option for Dojo Location")]
        public string DojoLocations {get; set;}

        [Required(ErrorMessage=" Select at Least One Option for Favorite Language")]
        public string FavLang {get;set;}
        // [NoZNames]
        public string Comments {get;set;}
    }
}