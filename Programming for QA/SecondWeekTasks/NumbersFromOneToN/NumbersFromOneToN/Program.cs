namespace NumbersFromOneToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}