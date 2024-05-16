namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius,2);
                Console.WriteLine($"{area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}