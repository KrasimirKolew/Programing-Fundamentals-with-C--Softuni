using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
