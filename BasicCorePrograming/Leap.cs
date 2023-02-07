using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Leap
    {
        public void Year()
        {
            Console.WriteLine(" Enter the leap Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());

            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                Console.WriteLine("its leap year");
            else
                Console.WriteLine("not a leap year");
        }
    }
}
