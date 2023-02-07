using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class VowelOrConsonant
    {
        public void CheckCharactor()
        {
            Console.WriteLine("Enter the charactor");
            char charctor = Convert.ToChar(Console.ReadLine());

            if (charctor == 'a' || charctor == 'e' || charctor == 'i' || charctor == 'o' || charctor == 'u' ||
                charctor == 'A' || charctor == 'E' || charctor == 'I' || charctor == 'O' || charctor == 'U')
            {
                Console.WriteLine(charctor + " is a Vowel");
            }
            else if (charctor <= 'a' && charctor >= 'z' || charctor <= 'A' && charctor >= 'Z')
            {
                Console.WriteLine(charctor + " is a Consonant");
            }
        }
    }
}
