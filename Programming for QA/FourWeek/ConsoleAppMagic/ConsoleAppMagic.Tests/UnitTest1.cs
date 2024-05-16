namespace ConsoleAppMagic.Tests
{
    public class Tests
    {

        [Test]
        public void Test_PrintEqualWordsFromTwoListOfStrings()
        {


            List<string> names = new List<string>() {
            "csharp", "java", "coding", "QA", "debugging", "python", "mysql"};
            List<string> langs = new List<string>() {
            "csharp", "java", "python", "php", "javascript"};

            List<string> expectedOutput = new List<string>() {
            "coding", "QA", "debugging", "mysql"};

            List<string> output = names.Except(langs).ToList();

            CollectionAssert.AreEqual(expectedOutput, output);
        }
    }
}