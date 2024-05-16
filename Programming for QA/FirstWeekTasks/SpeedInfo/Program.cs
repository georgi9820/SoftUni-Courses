namespace SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if (num <= 30)
            {
                Console.WriteLine("Slow");
            }
            else
            {
                Console.WriteLine("Fast");
            }
        }
    }
}