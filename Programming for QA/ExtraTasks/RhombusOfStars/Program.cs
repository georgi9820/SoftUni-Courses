using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Горна част на ромба
        for (int row = 1; row <= n; row++)
        {
            // Отпечатваме интервали
            for (int space = 1; space <= n - row; space++)
            {
                Console.Write(" ");
            }

            // Отпечатваме звезда
            Console.Write("*");

            // Отпечатваме оставащите звезди
            for (int stars = 1; stars < row; stars++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }

        // Долна част на ромба
        for (int row = n - 1; row >= 1; row--)
        {
            // Отпечатваме интервали
            for (int space = 1; space <= n - row; space++)
            {
                Console.Write(" ");
            }

            // Отпечатваме звезда
            Console.Write("*");

            // Отпечатваме оставащите звезди
            for (int stars = 1; stars < row; stars++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}



