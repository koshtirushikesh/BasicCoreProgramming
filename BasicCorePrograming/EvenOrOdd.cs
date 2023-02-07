using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class EvenOrOdd
    {
        public void CheckNumberEvenOrOdd()
        {
            Console.WriteLine("Enter the number to find out number is EvenOrOdd or odd ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine($"the {number} is even");
            else
                Console.WriteLine($"the {number} is odd");
        }
    }
}
