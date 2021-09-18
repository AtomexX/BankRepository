using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CalcIntrest : ICalcIntrest
    {
        public int Calculate(int principle, int rateOfInt, int year)
        {
            int simpleIntrest = (principle * rateOfInt * year) / 100;
            return simpleIntrest;
        }
    }
}
