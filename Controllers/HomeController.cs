using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DojoSurveyWithValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace DojoSurveyWithValidation.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost ("surveyForm")]
        public IActionResult surveyForm (Survey survey) {
            Console.WriteLine("#################"+survey+"#################");
            if (ModelState.IsValid) {

                return View("success",survey);
            } else 
            {
                return View("Index");
            }
        }
    
        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}