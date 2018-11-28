using System;
namespace MathLib
{
    public class Calculations
    {
        public decimal Addition(decimal LeftOperand, decimal RightOperand)
        {
            return LeftOperand + RightOperand;
        }
        public decimal Subtraction(decimal LeftOperand, decimal RightOperand)
        {
            return LeftOperand - RightOperand;
        }
        public decimal Multiplication(decimal LeftOperand, decimal RightOperand)
        {
            return LeftOperand * RightOperand;
        }
        public decimal Division(decimal LeftOperand, decimal RightOperand)
        {
            return LeftOperand / RightOperand;
        }
    }
}
