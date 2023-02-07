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
            Console.WriteLine("8. Even or Odd");
            Console.WriteLine("9. Vowel or Consonant");
            Console.WriteLine("10. Largest Among the Three Number");
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
                case 2:
                    Console.WriteLine("Leap Year is runing");
                    Leap leap = new Leap();
                    leap.Year();
                    break;
                case 3:
                    Console.WriteLine("Power of 2 is runing");
                    PowerOf powerOf = new PowerOf();
                    powerOf.TwoTable();
                    break;
                case 4:
                    Console.WriteLine("Harmonic Number is runing ");
                    HermonicNumber hermonicNumber = new HermonicNumber();
                    hermonicNumber.CalculateHermonicNumber();
                    break;
                case 5:
                    Console.WriteLine("Fators is running");
                    Factors factors = new Factors();
                    factors.FactorNumers();
                    break;
                case 6:
                    Console.WriteLine("Quotient and Remainder is runnig");
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.ComputeQuotientAndRemainder();
                    break;
                case 7:
                    Console.WriteLine("Swap number is running");
                    Swap swap = new Swap();
                    swap.SwapTwoNumber();
                    break;
                case 8:
                    Console.WriteLine("Even or Odd is running");
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.CheckNumberEvenOrOdd();
                    break;
                case 9:
                    Console.WriteLine("Vowel or Consonant is running");
                    VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                    vowelOrConsonant.CheckCharactor();
                    break;
                case 10:
                    Console.WriteLine("Largest Among the Three Number is running");
                    LargestAmong largestAmong = new LargestAmong();
                    largestAmong.ThreeNumber();
                    break;

            }
            Console.ReadLine();
        }
    }
}
