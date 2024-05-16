int n = int.Parse(Console.ReadLine());

int result = 1;
int number = 2;

for (int power = 0; power <= n; power += 2)
{
    Console.WriteLine(result);
    result = 2 * result * number;
}
