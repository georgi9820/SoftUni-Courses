using System;

string type = Console.ReadLine();
string firstValue = Console.ReadLine();
string secondValue = Console.ReadLine();

CompareTwoValues(type, firstValue, secondValue);
static void CompareTwoValues(string type, string firstValue, string secondValue)
{
    switch (type)
    {
        case "int":
            int firstNum = int.Parse(firstValue);
            int secondNum = int.Parse(secondValue);
            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
            break;
        case "char":
            char firstCh = char.Parse(firstValue);
            char secondCh = char.Parse(secondValue);
            int result = firstCh.CompareTo(secondCh);

            if (result > 0)
            {
                Console.WriteLine(firstCh);
            }
            else if (result < 0)
            {
                Console.WriteLine(secondCh);
            }
            break;
        case "string":
            if (firstValue.CompareTo(secondValue) > 0)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
            break;
    }
}