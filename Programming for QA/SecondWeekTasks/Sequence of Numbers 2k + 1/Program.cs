﻿namespace Sequence_of_Numbers_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 1;

            while (p <= n)
            {
                Console.WriteLine(p);
                p = p * 2 + 1;
            }
        }
    }
}