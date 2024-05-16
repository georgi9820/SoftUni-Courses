﻿namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int piecesLeft = width * length;
            string input = Console.ReadLine();

            while (input != "STOP") 
            { 
                int pieceTaken = int.Parse(input);
                piecesLeft -= pieceTaken;
                if (piecesLeft < 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (piecesLeft >= 0)
            {
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {-1 * piecesLeft} pieces more.");
            }
        }
    }
}