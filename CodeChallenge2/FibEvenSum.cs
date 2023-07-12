using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public class FibEvenSum
    {
        static void Main(string[] args)
        {
            int evenSum = 0;
            int value1 = 1;
            int value2 = 2;
            int temp = 0;

            while(value2 < 4000000)
            {
                if(value2 % 2 == 0)
                {
                    evenSum += value2;
                }

                temp = value2;
                value2 += value1;
                value1 = temp;
            }

            Console.WriteLine(evenSum);
        }

    }
}
