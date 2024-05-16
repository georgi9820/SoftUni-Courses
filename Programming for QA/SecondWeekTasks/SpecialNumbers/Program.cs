namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (n % i == 0 && n % j == 0 && n % k == 0 && n % l == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
            //int n = int.Parse(Console.ReadLine());

            //for (int digit = 1111; digit <= 9999; digit++)
            //{
            //    String digits = digit.ToString();
            //    bool isSpecial = true;
            //    for (int i = 0; i < digits.Length; i++)
            //    {
            //        int currentDigit = int.Parse(digits[i].ToString());

            //        if (currentDigit == 0)
            //        {
            //            isSpecial = false;
            //            break;
            //        }

            //        if (n % currentDigit != 0)
            //        {
            //            isSpecial = false;
            //            break;
            //        }
            //    }

            //    if (isSpecial)
            //    {
            //        Console.Write(digits + " ");
            //    }
            //}

            //Console.WriteLine();
        }
    }
}
