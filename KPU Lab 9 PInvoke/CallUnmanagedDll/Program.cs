using System;
using System.Runtime.InteropServices;

namespace CallUnmanagedDll
{
    class Program
    {
        [DllImport("lab1_1.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int myAdd(int number1, int number2);

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine($"This is the result of 2+3: {myAdd(2, 3)}");
            

        }
    }
}