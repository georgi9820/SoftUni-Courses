namespace GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (numOne > numTwo)
            {
                Console.WriteLine($"Greatet number: {numOne}");
            }
            else
            {
                Console.WriteLine($"Greatet number: {numTwo}");
            }
        }
    }
}