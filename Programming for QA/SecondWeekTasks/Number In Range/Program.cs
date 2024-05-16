int num = int.Parse(Console.ReadLine());

while (true)
{
    if (num >= 1 && num <= 100)
    {
        Console.WriteLine(num);
        break;
    }
    else
    {
        num = int.Parse(Console.ReadLine());
    }
    
    
}


