namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            string modDiv = "";
            int result = 0;
            int remainder = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 == 0)
                    {
                        modDiv = " - even";
                    }
                    else
                    {
                        modDiv = " - odd";
                    }
                    Console.WriteLine($"{num1} + {num2} = {result}{modDiv}");
                    break;
                case "-":
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        modDiv = " - even";
                    }
                    else
                    {
                        modDiv = " - odd";
                    }
                    Console.WriteLine($"{num1} - {num2} = {result}{modDiv}");
                    break;
                case "*":
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        modDiv = " - even";
                    }
                    else
                    {
                        modDiv = " - odd";
                    }
                    Console.WriteLine($"{num1} * {num2} = {result}{modDiv}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        remainder = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {remainder}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    break;
            }
        }
    }
}