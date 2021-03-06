﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{

    class Program
    {


        static public int Problem1()
        {
            // problem 1 g16m3797
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (3 % i == 0 || 5 % i == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum for problem one is " + sum);
            Console.ReadLine();
        }


        static void Main(string[] args)
        {

            Problem1();
            SumOfDiff();
            prime();
        }

        static void prime()
        {
            int upperLimit = 10001;
            int counter = 1;
            bool isPrime;
            int j;
            List<int> primes = new List<int>();

            primes.Add(2);

            while (primes.Count < upperLimit)
            {
                counter += 2;
                j = 0;
                isPrime = true;
                while (primes[j] * primes[j] <= counter)
                {
                    if (counter % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(counter);
                    Console.WriteLine("the 10 001st prime number is" + counter);
                    Console.ReadLine();
                }
            }
        }

       
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





    }
} 
    
