using System.Runtime.ConstrainedExecution;

int m = int.Parse(Console.ReadLine());

int counter = 0;
string password = null;

for (int a = 1; a < 10; a++)
{
    for (int b = 1; b < 10 ; b++)
    {
        for (int c = 1; c < 10; c++)
        {
            for (int d = 1; d < 10; d++)
            {
                
                
                if (a < b && c > d)
                {
                    int sum = a * b + c * d;

                    if (sum == m)
                    {
                        Console.Write($"{a}{b}{c}{d} ");
                        counter++;
                        if (counter == 4)
                        {
                            password = $"{a}{b}{c}{d}";
                        }
                    }  
                }
            }
        }
    }
}

if (counter > 0)
    Console.WriteLine();
if (password != null)
    Console.WriteLine($"Password: {password}");
else
    Console.WriteLine("No!");

