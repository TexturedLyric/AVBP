using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UCMVC2.Models;

namespace UCMVC2.Controllers
{
    public class ConverterController : Controller
    {
        public string Add(decimal left, decimal right)
        {
            return $"{left} plus {right} is: {left + right}";
        }
        public string Ceiling(decimal number)
        {
            decimal result = Math.Ceiling(number);
            return $"The ceiling of {number} is {result}";
        }
    }
}
