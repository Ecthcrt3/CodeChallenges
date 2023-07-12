﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public class Fib10Digits
    {
        static void Main(string[] args)
        {
            int index = 0;
            int value1 = 1;
            int value2 = 1;
            int temp = 0;

            do
            {
                index++;

                temp = value2;
                value2 += value1;
                value1 = temp;
            } while (value2 < 100000000);

            Console.WriteLine($"The index of the first number with 10 digits is {index} ");
        }
    }
}
