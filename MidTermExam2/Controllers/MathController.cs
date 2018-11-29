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

        //Added classes DoCalculation and ShowCalculationResult

        [HttpGet]
        public IActionResult DoCalculation(decimal LeftOperand, decimal RightOperand, string Operater)
        {
            
            //This is the operations that is supposed to run for the program. 

            switch(Operater)
            {
                /*
                case "Add":
                case "add":
                case "addition":
                case "Addition":
                    Console.WriteLine("Add check");
                    decimal result = MathLib.Calculations.Addition(LeftOperand, RightOperand);
                break;

                case "Subtract":
                case "subtract":
                    Console.WriteLine("Sub check");
                    decimal Subresult = MathLib.Calculations.Subtraction(LeftOperand, RightOperand);
                break;

                case "Multiply":
                case "multiply":
                    Console.WriteLine("Mult check");
                    decimal Multresult = Calculations.Multiplication(LeftOperand, RightOperand);
                break;

                case "Divide":
                case "divide":
                    Console.WriteLine("Div check");
                    decimal Divresult = Calculations.Division(LeftOperand, RightOperand);
                break;
            */
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult ShowCalculationResults()
        {

            return View();
        }
    }
}