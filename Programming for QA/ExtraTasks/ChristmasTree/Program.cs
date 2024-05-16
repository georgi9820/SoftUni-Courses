using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row <= n; row++)
        {
            
            for (int space = 1; space <= n - row; space++)
            {
                Console.Write(" ");
            }

            for (int stars = 1; stars <= row; stars++)
            {
                Console.Write("*");
            }

            Console.Write("*");

            for (int stars = 1; stars <= row; stars++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}



