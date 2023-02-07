using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Flip
    {
        int countHead = 0, countTail = 0;
        public void Coin()
        {
            Console.WriteLine("Enter The number of times to Flip Coin ");
            int N_TimeFlipCoin = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < N_TimeFlipCoin; i++)
            {
                double numCheck = random.NextDouble();
                if (numCheck < 0.5)
                    countHead++;
                else
                    countTail++;
            }

            Console.WriteLine(countHead + " " + countTail);
            float headPersentage = (float)countHead / N_TimeFlipCoin * 100;
            float tailPersentage = (float)countTail / N_TimeFlipCoin * 100;
            Console.WriteLine(headPersentage + " " + tailPersentage);
        }

        public void Coin1()
        {
            Console.WriteLine("Enter The number of times to Flip Coin ");
            int N_TimeFlipCoin = Convert.ToInt32(Console.ReadLine());
            int Head = 1;
            Random random = new Random();

            for (int i = 0; i < N_TimeFlipCoin; i++)
            {
                int numCheck = random.Next(2);

                if (Head == numCheck)
                    countHead++;
                else
                    countTail++;
            }

            Console.WriteLine(countHead + " " + countTail);
            float headPersentage = (float)countHead / N_TimeFlipCoin * 100;
            float tailPersentage = (float)countTail / N_TimeFlipCoin * 100;
            Console.WriteLine(headPersentage + " " + tailPersentage);
        }
    }
}
