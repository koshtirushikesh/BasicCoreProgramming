using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Factors
    {
        public void FactorNumers() 
        {
            Console.WriteLine("Compute the prime factorization of N using brute force.");
            Console.WriteLine("Enter the value");
            int num =Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=num; i++)
            {
                for(int j=1; j<=i;j++)
                {
                    if(num==i*j)
                    {
                        Console.WriteLine($"factors {i} {j}");
                        if (CheckForPrime(i) && CheckForPrime(j))
                            Console.WriteLine($"Prime Factors :{i} {j}");
                       
                    }
                }
            }
        }

        public bool CheckForPrime(int num)
        {
            int temp = 0;
            for(int i=2; i<num/i; i++)
            {
               if(num%i==0) { temp++;break; }
            }
            if (temp == 0)
                return true;
            else
                return false;
        }
    }
}
