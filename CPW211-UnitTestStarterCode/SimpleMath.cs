using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public static double Subtract(double a, double b)
        {
            double sum = a - b;
            return sum;
        }

        public static double Multiply(double a, double b)
        {
            double sum = a * b;
            return sum;
        }

        public static double Divide(double a, double b)
        {
            // If "a" or "b" has a value of 0
            // throw ArgumentException
            if (a == 0 || b == 0) 
            {
                throw new ArgumentException($"You cannot divide with a zero");
            }
            else
            {
                double sum = a * b;
                return sum;
            }
        }
    }
}
