using System;
using ConvertLib;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTempCon converter = new MyTempCon();

            Console.WriteLine(MyTempCon.CelToFar(20));
        }
    }
}
