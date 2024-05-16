namespace BoilingWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            if (degrees > 100)
            {
                Console.WriteLine("The water is boiling");
            }
            else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}