using System;

namespace Eular_Problem_1___B
{

    /// <summary>
    /// TEB:
    /// TODO:  Add a description of the class
    /// 
    /// This is the Program class.  It is a simple class that outputs to the console.
    /// The program  produces a list of multiplies of 3 and 5 between 1 and below 1000.
    /// 
    /// TODO: Enhance the description of the class.
    /// /// </summary>
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

            for ( int x = 1; x < 1000; x++)
            {
                if ( multipleOfThree(x) )
                    Console.WriteLine(x.ToString());
                else if (multipleOfFive(x))
                    Console.WriteLine(x.ToString());
            }

            Console.WriteLine("Hello World!");
        }
    }
}
