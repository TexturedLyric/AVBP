using System;

namespace UCMVC3_with_razor_.Models
{
    public class ConverterViewModel
    {
        public decimal ValueToConvert{get; set;}

        public string ConType{get; set;}
        public decimal ConvertedValue {get; set;}
    }
}