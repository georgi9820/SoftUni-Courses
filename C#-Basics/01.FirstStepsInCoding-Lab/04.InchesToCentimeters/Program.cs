using System;

namespace _04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numInInches = double.Parse(Console.ReadLine());
            double numInCentimetres = numInInches * 2.54;

            Console.WriteLine(numInCentimetres);
        }
    }
}
