﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= numb; i++)
            {
                factorial *= i;

            }
            Console.WriteLine(factorial);
        }
    }
}
