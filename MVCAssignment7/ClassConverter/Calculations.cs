using System;

namespace ClassConverter
{
    public class Class1
    {
        public decimal CelToFar(decimal value)
        {
            return (9m/5m)*(value)+32;
        }
        public decimal FarToCel(decimal value)
        {
            return (5m/9m)*(value-32);
        }
        public decimal FeetToYard(decimal value)
        {
            return value/3;
        }
        public decimal YardToFeet(decimal value)
        {
            return value*3;
        }
        public decimal FeetToMeter(decimal value)
        {
            return value/(1250/381);
        }
        public decimal MeterToFeet(decimal value)
        {
            return value*(1250/381);
        }
        public decimal OunceToPound(decimal value)
        {
            return value/16;
        }
        public decimal PoundToOunce(decimal value)
        {
            return value*16;
        }
        public decimal OunceToGram(decimal value)
        {
            return value*28;
        }
        public decimal GramToOunce(decimal value)
        {
            return value/28;
        }
        public decimal GramToKilo(decimal value)
        {
            return value/1000;
        }
        public decimal KiloToGram(decimal value)
        {
            return value*1000;
        }
    }
}
