int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int sum = 0;
    string text = i.ToString();

    for (int k = 0; k < text.Length; k++)
    {
        int divisor = 0;
        int digit = int.Parse(text[k].ToString());
        for (int j = 1; j <= digit; j++)
        {
            if (digit % j == 0)
            {
                divisor++;
            }
        }

        if (divisor == 2)
        {
            
            sum += int.Parse(text[k].ToString());

        }
        else
        {
            sum = 0;
            break;
        }

    }
    if (sum % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}


//for (int i = 0; i < n; i++)
//{
//    int divisor = 0;
//    for (int j = 1; j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            divisor++;
//        }
//    }

//    if (divisor == 2)
//    {
//        int sum = 0;
//        string text = i.ToString();

//        for (int k = 0; k < text.Length; k++)
//        {
//            sum += int.Parse(text[k].ToString());
//        }

//        if (sum % 2 == 0)
//        {
//            Console.Write($"{text} ");
//        }
//    }

//}
