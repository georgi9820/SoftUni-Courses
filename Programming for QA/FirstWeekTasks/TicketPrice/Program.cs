namespace TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            double price = 0;
            if (ticketType == "student")
            {
                price += 1.00;
                Console.WriteLine($"${price:F2}");
            }
            else if (ticketType == "regular")
            {
                price += 1.60;
                Console.WriteLine($"${price:F2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}