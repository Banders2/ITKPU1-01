using System;
using KPU_Lab_NugetV2;

namespace UseNugetPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Substract(1, 2));
            Console.WriteLine(calculator.Multiply(1, 2));
            Console.WriteLine(calculator.Divide(1, 2));
            Console.WriteLine(calculator.Pow(1, 2));
            Console.WriteLine(calculator.Log(1, 2));
            Console.WriteLine(calculator.Abs(1));

        }
    }
}