using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;

namespace IterationStatements
{
    internal class Program
    {
        public static void int CountTo1000()
        {
            var theCount = new List<int>();
            var currentCount = 0;
            for (int i = 0; i < 1000; i++)
            {
                currentCount++;
                theCount.Add(currentCount);
                Console.WriteLine( $"{theCount[i]}");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountTo1000());
        }
    }
}