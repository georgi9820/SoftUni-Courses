namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int leftMoney = 0;
            string input;
            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "Facebook": 
                        salary -= 150; break;
                    case "Instagram":
                        salary -= 100; break;
                    case "Reddit":
                        salary -= 50; break;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
            
            
        }
    }
}