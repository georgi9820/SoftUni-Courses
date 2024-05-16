namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
           int rows = int.Parse(Console.ReadLine());
           int cols = int.Parse(Console.ReadLine());
           double income = 0.0;
           double premierPrice = 12.00;
           double normalPrice = 7.50;
           double discountPrice = 5.00;
           if (type == "Premiere")
           {
               income = rows * cols * premierPrice;
           }
           else if (type == "Normal")
           {
               income = rows * cols * normalPrice;
           }
           else if(type == "Discount")
           {
               income = rows * cols * discountPrice;
           }
           Console.WriteLine("{0:f2} leva", income);
        }
    }
}