namespace CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int totalStandartTickets = 0;
            int totalStudentTickets = 0;
            int totalKidTickets = 0;

            while (true)
            {
                string moveName = Console.ReadLine();

                if (moveName == "Finish")
                {
                    break;
                }

                int movieSize = int.Parse(Console.ReadLine());
                int movieSoldTickets = 0;

                while (movieSoldTickets < movieSize)
                {
                    string typeOfTickets = Console.ReadLine();

                    if (typeOfTickets == "End")
                    {
                        break;
                    }

                    movieSoldTickets++;
                    switch (typeOfTickets)
                    {
                        case "standard":
                            totalStandartTickets++;
                            break;
                        case "student":
                            totalStudentTickets++;
                            break;
                        case "kid":
                            totalKidTickets++;
                            break;
                    }
                }

                Console.WriteLine($"{moveName} - {movieSoldTickets * 100.0 / movieSize:f2}% full.");

            }

            int totalTickets = totalStandartTickets + totalKidTickets + totalStudentTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{totalStudentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{totalStandartTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{totalKidTickets * 100.0 / totalTickets:f2}% kids tickets.");
        }


    }
}