using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CallBeep
{
    class Wrapper
    {
        [DllImport("Kernel32", SetLastError = true)]
        public static extern int Beep(uint freq, uint duration);
    }
}
