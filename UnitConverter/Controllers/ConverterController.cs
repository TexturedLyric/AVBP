using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;

namespace UnitConverter.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return $"{type} and {unitvalue}";
            return View();
        }

        public string FarToCel(decimal TempInCel)
        {

        }
    }
}
