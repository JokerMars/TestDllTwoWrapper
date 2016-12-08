using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DllWrapper
{
    public class Hello
    {
        [DllImport("Dll.dll", EntryPoint = "hello", ExactSpelling = false,
            CallingConvention = CallingConvention.Cdecl)]
        public extern static void hello();

        public static void SayHello()
        {
            hello();
        }

    }
}
