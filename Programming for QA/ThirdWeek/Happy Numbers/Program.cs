﻿
int n = int.Parse(Console.ReadLine());

for (int d1 = 1; d1 <= 9; d1++)
{
    for (int d2 = 0; d2 <= 9; d2++)
    {
        for (int d3 = 0; d3 <= 9; d3++)
        {
            for (int d4 = 0; d4 <= 9; d4++)
            {
                if (d1 + d2 == n && d3 + d4 == n) 
                {
                    Console.Write($"{d1}{d2}{d3}{d4} ");
                }
            }
        }
    }
}
