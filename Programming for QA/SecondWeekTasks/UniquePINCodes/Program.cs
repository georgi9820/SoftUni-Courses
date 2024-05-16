namespace UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n1; i += 2)
            {
                for (int j = 2; j <= n2; j++)
                {
                    int divisor = 0;
                    for (int d = 1; d <= j; d++)
                    {
                        if (j % d == 0)
                        {
                            divisor++;
                        }
                    }

                    if (divisor == 2) 
                    {
                        for (int k = 2; k <= n3; k += 2)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
               
            }
        }
    }
}

