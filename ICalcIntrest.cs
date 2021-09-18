using System;

namespace BankLibrary
{
    public interface ICalcIntrest
    {
        public int Calculate(int principle, int rateOfInt, int year);
    }
}
