namespace ConsoleAppMagic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {
            "csharp", "java", "coding", "QA", "debugging", "python", "mysql"};
            List<string> langs = new List<string>() {
            "csharp", "java", "python", "php", "javascript"};

            List<string> output = new List<string>();
            output = names.Except(langs).ToList();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}