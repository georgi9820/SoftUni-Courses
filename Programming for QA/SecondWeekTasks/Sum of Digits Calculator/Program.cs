string input = Console.ReadLine();


while (input != "End")
{
    int sumOfDigit = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int digit = int.Parse(input[i].ToString());
        sumOfDigit += digit;
    }

    Console.WriteLine($"Sum of digits = {sumOfDigit}");
    input = Console.ReadLine();
}
Console.WriteLine("Goodbye");

