using System;
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
        }

       

        
    }
}
