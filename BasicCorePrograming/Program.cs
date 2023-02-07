using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Flip Coin ");
            Console.WriteLine("2. Leap Year ");
            Console.WriteLine("3. power of 2");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Factors");
            Console.WriteLine("6. Quotient and Remainder");
            Console.WriteLine("7. swap number");
            Console.WriteLine("Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Flip Coin");
                    Flip flip = new Flip();
                    flip.Coin();
                    flip.Coin1();
                    ; break;
                
            }
            Console.ReadLine();
        }
    }
}
