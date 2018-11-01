using System;

namespace ConvertLib
{
    interface ITempCon
    {
        decimal CelToFar(decimal TempInCel);
    }

    public class MyTempCon
    {
        public static decimal CelToFar(decimal TempInCel)
        {
            return TempInCel * 9m/5m + 32;
        }
    }
    public class AltTempCon
    {
        public static decimal CelToFar(decimal TempInCel)
        {
            return TempInCel * 1.8m + 32;
        }
    }
}
