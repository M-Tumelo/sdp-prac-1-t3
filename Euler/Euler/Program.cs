﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        #region The function SumOfDiff writes the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum
        static public void SumOfDiff()
        {
            double result = 0;
            double square = 0;                                      //This was written by Tumelo
            for (double i = 0; i <= 100; i++)
            {
                square += Math.Pow(i, 2);                           // This line adds i raised to the power of two
                result += i;                                        // This line finds the total sum of the first 100 numbers 
            }
            Console.Write("Sum of Difference: ");
            Console.WriteLine(Math.Pow(result, 2) - square);
            Console.Read();
        }
        #endregion
        static void Main(string[] args)
        {
            SumOfDiff();
        }
    }
}
