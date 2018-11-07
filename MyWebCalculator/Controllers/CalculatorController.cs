using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;

using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public string Add(decimal left, decimal right)
        {
            return $"{left} plus {right} is: {MyMathRoutines.Add(left,right)}";
        }
        public decimal Subtract(decimal left, decimal right)
        {
            return $"{left} minus {right} is: {MyMathRoutines.Subtract(left,right)}";
        }
        public decimal Multiply(decimal left, decimal right)
        {
            return $"{left} times {right} is: {MyMathRoutines.Multiply(left,right)}";
        }
        public decimal Divide(decimal left, decimal right)
        {
            return $"{left} Divided {right} is: {MyMathRoutines.Divide(left,right)}";
        }
        public double Power(double left, double right)
        {
            return $"{left} to the power of {right} is: {MyMathRoutines.Power(left,right)}";
        }
        public decimal Ceiling(decimal number)
        {
            return $"{number} ceiling is: {MyMathRoutines.Ceiling(number)}";
        }
        public decimal Floor(decimal number)
        {
            return $"{number} floor is: {MyMathRoutines.floor(number)}";
        }
    }
}
