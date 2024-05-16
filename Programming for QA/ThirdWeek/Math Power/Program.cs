int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

Console.WriteLine(NumberPowers(baseNumber, power));
static double NumberPowers(int baseNumber, int power)
{
    double raisedNumber = Math.Pow(baseNumber, power);
    return raisedNumber;
}
