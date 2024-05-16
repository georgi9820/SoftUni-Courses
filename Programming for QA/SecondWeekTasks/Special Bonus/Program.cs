int stopNumber = int.Parse(Console.ReadLine());
int previousNumber = stopNumber;
double result = 0;
while (stopNumber > 0)
{
    int input = int.Parse(Console.ReadLine());
   
    if (input == stopNumber)
    {
        result = previousNumber * 1.2;
        Console.WriteLine(result);
        break;
    }
    previousNumber = input;
}
