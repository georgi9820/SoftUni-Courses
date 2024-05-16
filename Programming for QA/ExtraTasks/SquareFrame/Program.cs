using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Отпечатайте горната част
        Console.Write("+");
        for (int i = 0; i < n - 2; i++)
            Console.Write(" -");
        Console.WriteLine(" +");

        // Отпечатайте средната част
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("|");
            for (int j = 0; j < n - 2; j++)
                Console.Write(" -");
            Console.WriteLine(" |");
        }

        // Отпечатайте долната част
        Console.Write("+");
        for (int i = 0; i < n - 2; i++)
            Console.Write(" -");
        Console.WriteLine(" +");
    }
}



