int number = int.Parse(Console.ReadLine());
try
{
    if (number < 0)
    {
        throw new ArgumentException();
    }

    double sqrt = Math.Sqrt(number);
    Console.WriteLine(sqrt);
}
catch
{
    Console.WriteLine("Invalid number.");
}
finally 
{ 
    Console.WriteLine("Goodbye."); 
}

