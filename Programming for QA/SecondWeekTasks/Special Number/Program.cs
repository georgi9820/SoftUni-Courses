using System;

int n = int.Parse(Console.ReadLine());

bool isSpecial = true;
int startNumber = n;
while (n > 0)
{
    int lastNumber = n % 10;
    if (startNumber % lastNumber != 0)
    {
        isSpecial = false;
        break;
    }

    n = n / 10;
}

if (isSpecial)
{
    Console.WriteLine($"{startNumber} is special");
}
else
{
    Console.WriteLine($"{startNumber} is not special");
}
