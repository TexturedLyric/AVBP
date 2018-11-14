using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UCMVC3_with_razor_.Models;

namespace UCMVC3_with_razor_.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            ViewData["message"] = "This is the message!";
            return View();
        }
        public IActionResult Converter()
        {
            ViewData["message"] = "This is the message!";
            return View();
        }
        [HttpPost]
        public IActionResult DoConversion(ConverterViewModel model)
        {
            model.ConvertedValue = model.ValueToConvert * model.ValueToConvert;
            return View(model);
        }
    }
}
