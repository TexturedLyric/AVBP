using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVC.Models;

namespace UnitConverterMVC.Controllers
{
    public class ConverterController : Controller
    {
        public string Index(string type, string unitvalue)
        {
            Double val = Convert.ToDouble(unitvalue);
            val *= 4;

            return $"{type} and {val}";
        }
    }
}
