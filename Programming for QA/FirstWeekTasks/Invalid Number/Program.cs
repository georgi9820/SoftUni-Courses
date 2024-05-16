int num = int.Parse(Console.ReadLine());

bool  isValid = true;

if ((num != 0 && num < 100) || num > 200)
{
    isValid = false;
    Console.WriteLine("invalid");
}
