string input = Console.ReadLine();

int sum = 0;

for (int i = 0; i < input.Length; i++)
{
    int number = int.Parse(input[i].ToString());
    if (number % 2 == 0)
    {
        int currentDigitFac = Factorial(number);
        sum += currentDigitFac;
    }
}

Console.WriteLine(sum);
static int Factorial(int number)
{
    if (number == 0)
    {
        return 1;
    }

    return number * Factorial(number - 1);
}