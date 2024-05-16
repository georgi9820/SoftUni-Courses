int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        for (int k = start; k <= end; k++)
        {
            for (int l = start; l <= end; l++)
            {
                if (i % 2 == 0 && l % 2 != 0 && i > l)
                {
                    sum = j + k;
                    if (sum % 2 == 0)
                    {
                        Console.Write($"{i}{j}{k}{l} ");
                    }
                    
                }
                else if (i % 2 != 0 && l % 2 == 0 && i > l)
                {
                    sum = j + k;
                    if (sum % 2 == 0)
                    {
                        Console.Write($"{i}{j}{k}{l} ");
                    }
                }
                
            }
        }
    }
}
