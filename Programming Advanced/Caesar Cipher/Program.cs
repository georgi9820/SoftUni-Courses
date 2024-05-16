string input = Console.ReadLine();

char[] charArr = input.ToCharArray();

for (int i = 0; i < charArr.Length; i++)
{
    Console.WriteLine(charArr[i]);
}

//string input = Console.ReadLine();

//char[] charArr = input.ToCharArray();

//for (int i = 0; i < charArr.Length; i++)
//{
//    charArr[i] = Convert.ToChar(charArr[i] + 3);
//}

//Console.WriteLine(string.Join("", charArr));


//Вариант с List
//List<char> charInput = input.ToList();

//for (int i = 0; i < charInput.Count; i++)
//{
//    charInput[i] = Convert.ToChar(charInput[i] + 3);
//}

//Console.WriteLine(string.Join("", charInput));


