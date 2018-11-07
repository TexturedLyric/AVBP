using System;

namespace MathLibrary
{
    public class MyMathRoutines
    {
        public decimal Add(decimal left, decimal right)
        {
            return left + right;
        }
        public decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }
        public decimal Multiply(decimal left, decimal right)
        {
            return left * right;
        }
        public decimal Divide(decimal left, decimal right)
        {
            return left / right;
        }
        public double Power(double left, double right)
        {
            return Math.Pow(left, right);
        }
        public decimal Ceiling(decimal number)
        {
            return Math.Ceiling(number);
        }
        public decimal Floor(decimal number)
        {
            return Math.Floor(number);
        }
    }
}
