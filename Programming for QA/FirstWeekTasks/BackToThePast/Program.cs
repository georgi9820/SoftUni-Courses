namespace BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            int year = 1800;
            double moneyInherit = double.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            

            for (int i = year; i <= endYear; i++)
            {
                
                if (i % 2 == 0)
                {
                    moneyInherit -= 12000;
                } 
                else
                {
                    moneyInherit -= 12000 + (age * 50);
                }

                age++;
            }

            
            if (moneyInherit >= 0) 
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInherit:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyInherit):F2} dollars to survive.");
            }
        }
    }
}