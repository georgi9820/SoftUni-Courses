int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());


Console.WriteLine(FirstFactorial(firstNum) / SecondFactorial(secondNum));



static long FirstFactorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * FirstFactorial(n - 1);
    }
}

static long SecondFactorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * SecondFactorial(n - 1);
    }
}