using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Swap
    {
        public void SwapTwoNumber()
        {
            int a = 30, b = 50;
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);

            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
    }
}
