using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class HermonicNumber
    {
        public void CalculateHermonicNumber()
        {

            Console.WriteLine("Enter the Harmonic Number N");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(" =");

            for (int i = 0; i < number; i++)
            {
                Console.Write(" 1/" + i);
                if (i < number - 1)
                    Console.Write(" +");
            }
        }
    }
}
