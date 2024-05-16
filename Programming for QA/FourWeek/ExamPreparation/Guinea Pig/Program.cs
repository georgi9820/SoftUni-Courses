using System;

class Program
{
    static void Main(string[] args)
    {
        double food = double.Parse(Console.ReadLine());
        double hay = double.Parse(Console.ReadLine());
        double cover = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());

        double foodGr = food * 1000;
        double hayGr = hay * 1000;
        double coverGr = cover * 1000;
        double weightGr = weight * 1000;
        int days = 1;

        while (days <= 30)
        {
            foodGr -= 300;
            if (days % 2 == 0)
            {
                hayGr -= foodGr * 0.05;
            }
            if (days % 3 == 0)
            {
                coverGr -= weightGr * 0.3333;
            }
            days++;
        }

        double foodKg = foodGr / 1000;
        double hayKg = hayGr / 1000;
        double coverKg = coverGr / 1000;

        if (foodKg >= 0 && hayKg >= 0 && coverKg >= 0)
        {
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg:f2}, Hay: {hayKg:f2}, Cover: {coverKg:f2}.");
        }
        else
        {
            Console.WriteLine("Merry must go to the pet store!");
        }
    }
}




