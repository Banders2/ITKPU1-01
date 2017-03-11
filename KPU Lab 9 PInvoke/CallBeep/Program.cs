using System;

namespace CallBeep
{
    class Program
    {
        static void Main(string[] args)
        {
            int errorResult;
            int errorInfo;

            Console.WriteLine("Test of Beep");
            errorResult = Wrapper.Beep(2000, 500);
            if (errorResult == 0)		// In case of an error
                Console.WriteLine("Call of Beep returned an error.");

            Wrapper.Beep(2000, 500);
            Wrapper.Beep(3000, 450);
            Wrapper.Beep(4000, 400);
            Wrapper.Beep(5000, 350);
            Wrapper.Beep(6000, 300);
            Wrapper.Beep(7000, 250);
            Wrapper.Beep(8000, 200);
            Wrapper.Beep(9000, 150);
            Wrapper.Beep(10000, 100);
            Wrapper.Beep(11000, 500);
      
        }
    }
}