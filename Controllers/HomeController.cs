using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            Survey newSurvey = new Survey();
            return View("Index", newSurvey);
        }

        [Route("/result")]
        [HttpPost]
        public IActionResult Result(Survey submitted_survey)
        {
            if (ModelState.IsValid)
            {
                return View("Result", submitted_survey);
            }
            else
            {
                return View("Index");
            }

        }
    }
}
