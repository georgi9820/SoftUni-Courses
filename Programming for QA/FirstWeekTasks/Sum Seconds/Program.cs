int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int sumTime = first + second + third;
int mintues = sumTime / 60;
int seconds = sumTime % 60;

Console.Write(mintues);
Console.Write(":");
if (seconds < 10)
{
    Console.Write("0");
}
Console.Write(seconds);
