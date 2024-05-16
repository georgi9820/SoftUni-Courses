namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int tretedPatients = 0;
            int untretedPatients = 0;
            int doctors = 7;
            int dayCounter = 0;
            int patient;

            for (int i = 1; i <= period; i++)
            {
                dayCounter++;

                if (dayCounter % 3 == 0 && untretedPatients > tretedPatients)
                {
                    doctors++;
                }

                patient = int.Parse(Console.ReadLine());

                if (patient > doctors)
                {
                    untretedPatients += patient - doctors;
                    tretedPatients += doctors;
                }
                else
                {
                    tretedPatients += patient;
                }
  
            }

            Console.WriteLine($"Treated patients: {tretedPatients}.");
            Console.WriteLine($"Untreated patients: {untretedPatients}.");
        }
    }
}