int number = int.Parse(Console.ReadLine());
numberSign(number);
static void numberSign(int number)
{
    if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else 
    {
        Console.WriteLine($"The number {number} is positive.");
    }
}
