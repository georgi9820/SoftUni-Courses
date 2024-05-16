namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volumeOfAquarium = lenght * width * height;
            double volumeInLiters = volumeOfAquarium / 1000.0;
            double occupiedSpace = percentage / 100;
            double requiredLiters = volumeInLiters * (1 - occupiedSpace);
            Console.WriteLine(requiredLiters);
        }
    }
}