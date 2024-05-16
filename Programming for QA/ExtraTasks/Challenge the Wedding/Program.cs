using System;

class Program
{
    static void Main()
    {
        // Вход
        int numMen = int.Parse(Console.ReadLine());
        int numWomen = int.Parse(Console.ReadLine());
        int maxTables = int.Parse(Console.ReadLine());

        int currentTable = 1;

        // Генериране на срещи
        for (int man = 1; man <= numMen; man++)
        {
            for (int woman = 1; woman <= numWomen; woman++)
            {
                if (currentTable > maxTables)
                {
                    Console.WriteLine();
                    return;
                }

                Console.Write($"({man} <-> {woman}) ");
                currentTable++;
            }
        }

        Console.WriteLine();
    }
}




