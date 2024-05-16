using System;

int n = int.Parse(Console.ReadLine());

int countTwo = 0;
int countThree = 0;
int countFour = 0;

for (int i = 0; i < n; i++)
{
    int input = int.Parse((Console.ReadLine()));
    if (input % 2 == 0)
    {
        countTwo++;
    }

    if (input % 3 == 0)
    {
        countThree++;
    }

    if ((input % 4) == 0) 
    { 
        countFour++;
    }
}

Console.WriteLine($"{countTwo * 100.0 / n:F2}%");
Console.WriteLine($"{countThree * 100.0 / n:F2}%");
Console.WriteLine($"{countFour * 100.0 / n:F2}%");