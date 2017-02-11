using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPU_Lab_Nuget
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
