using System;

namespace Eular_Problem_1___B
{

    /// <summary>
    /// 
    ///
    ///         If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    ///         The sum of these multiples is 23.
    /// 
    ///         Find the sum of all the multiples of 3 or 5 below 1000. 
    /// 
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// TEB: Add a description of the function.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Predicate<int> multipleOfThree = i => i % 3 == 0;
            Predicate<int> multipleOfFive = i => i % 5 == 0;

            long sumOfNumbers = 0;

            for ( int x = 0; x < 1000; x++)
            {
                if (multipleOfThree(x))
                {
                    sumOfNumbers += x;
//                    Console.WriteLine(x.ToString());
                }
                else if (multipleOfFive(x))
                {
                    sumOfNumbers += x;
//                    Console.WriteLine(x.ToString());
                }
            }

            Console.WriteLine("Total of factors: " + sumOfNumbers.ToString());
            Console.WriteLine("Multiplies Of Three And Five Problem 1");
        }
    }
}
