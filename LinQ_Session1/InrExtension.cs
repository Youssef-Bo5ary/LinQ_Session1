using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Session1
{
    internal static class InrExtension
    {
        //Extension Method
        public static int Reverse(int value)
        {
            int ReversedNumber = 0, LastDigit;
            while (value > 0)
            {
                LastDigit = value % 10;
                ReversedNumber = ReversedNumber * 10 + LastDigit;
                value = value / 10;
            }
            return ReversedNumber;
        }


    }
}
