string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());

double totalExpenses = 0;
double pricePerNight = 0;

switch (season)
{
    case "Spring":
        if (accommodationType == "Hotel")
        {
            pricePerNight += 30;
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight += 10;
        }
        totalExpenses = (countOfDays * pricePerNight) * 0.8;
        break;
    case "Summer":
        if (accommodationType == "Hotel")
        {
            pricePerNight += 50;
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight += 30;
        }
        totalExpenses = countOfDays * pricePerNight;
        break;
    case "Autumn":
        if (accommodationType == "Hotel")
        {
            pricePerNight += 20;
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight += 15;
        }
        totalExpenses = (countOfDays * pricePerNight) * 0.7;
        break;
    case "Winter":
        if (accommodationType == "Hotel")
        {
            pricePerNight += 40;
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight += 10;
        }
        totalExpenses = (countOfDays * pricePerNight) * 0.9;
        break;
}
Console.WriteLine($"{totalExpenses:F2}");