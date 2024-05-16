namespace ValidTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool isValidTriangle = true;

            if (a + b <= c)
            {
                isValidTriangle = false;
                Console.WriteLine("Invalid Triangle");
            }
            else if (b + c <= a)
            {
                isValidTriangle = false;
                Console.WriteLine("Invalid Triangle");
            }
            else if (a + c <= b)
            {
                isValidTriangle = false;
                Console.WriteLine("Invalid Triangle");
            }
            else
                Console.WriteLine("Valid Triangle");
        }
    }
}