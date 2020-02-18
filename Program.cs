using System;
using System.Linq;
using TheAppFactory;

namespace TheAppFactory_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"The App Factory",70}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            double[] scores = new double[] { };
            int index = 0;
            var score = new Score();

            Console.WriteLine("Enter a score between 0 - 100 : [00 to exit]");
            Array.Resize(ref scores,scores.Length + 1);
            scores[index] = Convert.ToDouble(Console.ReadLine());
            while (scores[index] != 00)
            {
                index++;
                Console.WriteLine("Enter a score between 0 - 100 : [00 to exit]");
                Array.Resize(ref scores, scores.Length + 1);
                scores[index] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Array.Resize(ref scores, scores.Length - 1);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"Statistics",70}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"\t\t\t\t\t\tHighest score : {scores.Max()}");
            Console.WriteLine($"\t\t\t\t\t\tLowest score : {scores.Min()}");
            Console.WriteLine($"\t\t\t\t\t\tAverage score : {scores.Average()}");
        }
    }
}
