int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int maxPasswordGenerated = int.Parse(Console.ReadLine());

int currentPassword = 1;

char A = (char)35;
char B = (char)64;

for (int x = 1; x <= a; x++)
{
    for (int y = 1; y <= b; y++)
    {
        if (currentPassword > maxPasswordGenerated)
        {
            return;
        }

        if (A > (char)55)
        {
            A = (char)35;
        }
       
        if (B > (char)96)
        {
            B = (char)64;
        }

        Console.Write($"{A}{B}{x}{y}{B}{A}|");
        currentPassword++;

        A++;
        B++;

    }
}

