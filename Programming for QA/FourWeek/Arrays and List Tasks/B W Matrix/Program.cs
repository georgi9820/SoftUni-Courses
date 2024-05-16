using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[] letters = { 'B', 'W' };

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(letters[(i + j) % 2]);
            }
            Console.WriteLine();
        }
    }
}

