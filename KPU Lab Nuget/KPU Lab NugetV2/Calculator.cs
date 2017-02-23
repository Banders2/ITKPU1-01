using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPU_Lab_NugetV2
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Pow(double x, double y)
        {
            return Math.Pow(x,y);
        }

        public double Log(double x, double y)
        {
            return Math.Log(x, y);
        }

        public double Abs(double x)
        {
            return Math.Abs(x);
        }
        public double Test(double x)
        {
            return x;
        }
    }
}
