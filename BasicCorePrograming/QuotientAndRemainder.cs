using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class QuotientAndRemainder
    {
        int Quotient = 10 / 3;
        int Remainder = 10 % 3;
        
        public void ComputeQuotientAndRemainder()
        {
            Console.WriteLine("Quotient " + Quotient);
            Console.WriteLine("Remainder " + Remainder);
        }
    }
}
