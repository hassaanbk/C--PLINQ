using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hassaan_Khalil_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            // create array with size of 10 million of random integers in the range 1-500
            var values = Enumerable.Range(1, 10000000)
                                     .Select(x => random.Next(1, 500));

            //LINQ
            Console.WriteLine("With LINQ to Objects using a single core");
            var start = DateTime.Now;
            BigInteger sum = values.Sum();
            var distinct = values.Distinct();
            var end = DateTime.Now;

            var linqTime = end.Subtract(start).TotalMilliseconds;

            Console.WriteLine("Sum:" + sum);
            Console.WriteLine("Distinct: " + distinct.Count());
            Console.WriteLine("Time taken: " + linqTime);
            
            //PLINQ
            Console.WriteLine("With PLINQ using multiple cores");

            var pStart = DateTime.Now;
            BigInteger pSum = values.AsParallel().Sum();
            var pDistinct = values.AsParallel().Distinct();
            var pEnd = DateTime.Now;

            var plinqTime = pEnd.Subtract(pStart).TotalMilliseconds;

            Console.WriteLine("Sum:" + pSum);
            Console.WriteLine("Distinct: " + pDistinct.Count());
            Console.WriteLine("Time taken: " + plinqTime);

            // display time difference as a percentage
            Console.WriteLine("\nPLINQ took " +
               $"{((linqTime - plinqTime) / linqTime):P0}" +
               " less time than LINQ");

        }//end main
    }// end class
}//end namespace
