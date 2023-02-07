using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class PowerOf
    {
        public void TwoTable()
        {
            Console.WriteLine("enter number ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int table = (int)Math.Pow(2, i);
                Console.WriteLine(table);
            }

        }
    }
}
