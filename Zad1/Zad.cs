using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Zad
    {
        public bool isItEven(double a, double b)
        {
            if (a / b % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
