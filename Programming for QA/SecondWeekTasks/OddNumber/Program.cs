int num = int.Parse(Console.ReadLine());

while (true)
{
    if (num % 2 != 0)
    {
        Console.WriteLine(num);
        break;
    }
    num = int.Parse(Console.ReadLine());
}
