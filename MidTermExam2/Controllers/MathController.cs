using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidTermExam2.Models;

using MathLib;

namespace MidTermExam2.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult DoCalculation(decimal LeftOperand, decimal RightOperand)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowCalculationResults()
        {

            return View();
        }
    }
}