using System;

class Program
{
    static void Main()
    {
        char lastSector = char.Parse(Console.ReadLine());
        int rowsInFirstSector = int.Parse(Console.ReadLine());
        int seatsInOddRows = int.Parse(Console.ReadLine());

        int totalSeats = 0;

        for (char sector = 'A'; sector <= lastSector; sector++)
        {
            for (int row = 1; row <= rowsInFirstSector; row++)
            {
                int seatsInRow = (row % 2 == 1) ? seatsInOddRows : seatsInOddRows + 2;

                for (char seat = 'a'; seat < 'a' + seatsInRow; seat++)
                {
                    Console.WriteLine($"{sector}{row}{seat}");
                    totalSeats++;
                }
            }

            rowsInFirstSector++;
        }

        Console.WriteLine(totalSeats);
    }
}

