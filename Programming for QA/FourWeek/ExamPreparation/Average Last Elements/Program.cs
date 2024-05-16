using System;

int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int selection = int.Parse(Console.ReadLine());

int sum = 0;
int count = 0;

for (int i = numbers.Length - selection; i < numbers.Length; i++)
{
    sum += numbers[i];
    count++;
}

double average = (double)sum / count;
Console.WriteLine($"{average:F2}");
