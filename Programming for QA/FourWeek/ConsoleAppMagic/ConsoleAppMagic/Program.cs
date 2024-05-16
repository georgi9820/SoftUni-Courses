namespace ConsoleAppMagic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int primeCount = 0;
            Console.WriteLine("1");

            for (int i = 1; i <= n; i++)
            {
                int divisor = 0;

                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0 || i == 1)
                    {
                        divisor++;
                    }
                }

                if (divisor == 2)
                {
                    primeCount++;
                    for (int j = 1; j <= i; j++)
                    {
                        int divisor2 = 0;

                        for (int div = 1; div <= j; div++)
                        {
                            if (j % div == 0)
                            {
                                divisor2++;
                            }
                        }

                        if (divisor2 == 2 || j == 1)
                        {
                            Console.Write(1);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }

            





            //string input = Console.ReadLine();
            //string[] parts = input.Split(new char[] { '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
            //string decimalString = string.Join("", parts);
            //decimal n = decimal.Parse(decimalString);


            //int size = n.ToString().Length;

            //if (size == 1)
            //{
            //    Console.WriteLine(n);
            //}
            //else if (size > 1) 
            //{
            //    while (n > 9)
            //    {
            //        decimal sum = 0;
            //        string input2 = n.ToString();
            //        for (int i = 0; i < input2.Length; i++)
            //        {
            //            sum += int.Parse(input2[i].ToString());
            //        }

            //        n = sum;
            //    }
            //    Console.WriteLine(n);
            //}


            //List<string> names = new List<string>() {
            //"csharp", "java", "coding", "QA", "debugging", "python", "mysql"};
            //List<string> langs = new List<string>() {
            //"csharp", "java", "python", "php", "javascript"};

            //List<string> output = new List<string>();
            //output = names.Except(langs).ToList();

            //Console.WriteLine(string.Join(" ", output));
        }
    }
}