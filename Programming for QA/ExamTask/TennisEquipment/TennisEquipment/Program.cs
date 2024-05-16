using System.Diagnostics;

double tennisRacketPrice = double.Parse(Console.ReadLine());
int tennisRacketQuantity = int.Parse(Console.ReadLine());
int sneakersPairsQuantity = int.Parse(Console.ReadLine());

double tennisRacketsTotalPrice = tennisRacketPrice * tennisRacketQuantity;
double sneakerPairPrice = tennisRacketPrice / 6;
double sneakersTotalPrice = sneakerPairPrice * sneakersPairsQuantity;
double otherEquipmentPrice = (sneakersTotalPrice + tennisRacketsTotalPrice) * 0.2;

double totalPrice = sneakersTotalPrice + otherEquipmentPrice + tennisRacketsTotalPrice;

double pricePerDjokovic = totalPrice / 8;
double pricePerSponsors = totalPrice * 7 / 8;

Console.WriteLine($"Price to be paid by Djokovic {(int) pricePerDjokovic}");
Console.WriteLine($"Price to be paid by sponsors {(int)Math.Ceiling(pricePerSponsors)}");
