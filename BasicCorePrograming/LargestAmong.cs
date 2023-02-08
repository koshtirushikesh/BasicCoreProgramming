using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class LargestAmong
    {
        public void ThreeNumber()
        {
            Console.WriteLine("Enter 1st Number");
            int _num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number ");
            int _num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            int _num3 = Convert.ToInt32(Console.ReadLine());


            if (_num1.CompareTo(_num2) > 0 && _num1.CompareTo(_num3) > 0)
                Console.WriteLine("1st number is greater");
            else if (_num2.CompareTo(_num3) > 0 && _num2.CompareTo(_num1) > 0)
                Console.WriteLine("2nd number is greater");
            else if (_num3.CompareTo(_num2) > 0 && _num3.CompareTo(_num1) > 0)
                Console.WriteLine("3rd number is greater");
            else
                Console.WriteLine("All the number is same");

        }
    }
}
