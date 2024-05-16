using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                              .Split(" ")
                              .Select(int.Parse)
                              .ToArray();
        //Имаме последнователност от поне 1 елемент (ако масивът не е празен, има поне един елемент в него)
        //тази порменлива (currentCount) ще се увеличава винаги когато срещне равен елемент
        //Тя ще представлява броя на последователните равни числа
        int currentCount = 1;
        //Тази променлива се използва за следене на най-дългата намерена до момента последователност от равни числа.
        //Ако currentCount стане по-голям от maxCount, тя се актуализира със стойността на currentCount. 
        //Това ни позволява да определим дали текущата последователност е по-дълга от най-дългата намерена до момента.
        //Най-големия брой последователни равни числа
        int maxCount = 1;
        //Тази променлива съдържа стойността на текущия елемент, който се сравнява с предишния.
        //Тя е необходима, за да следим коя конкретна последователност от числа текущата променлива currentCount се отнася.
        //Когато последователността се промени(текущият елемент не е равен на предишния), променяме currentNumber, за да следим новата последователност.
        int currentNumber = numbers[0];
        //Тази променлива съдържа стойността на елемента, който съответства на най - дългата последователност.
        //Когато maxCount се актуализира, тази променлива също се актуализира със стойността на currentNumber, 
        //за да определим кой елемент съответства на най - дългата последователност.
        int maxNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentCount++;

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxNumber = currentNumber;
                }
            }
            else 
            {
                //Ако текущият елемент не е равен на предходния (ситуацията, когато текущата последователност приключва),
                //нулираме currentCount и обновяваме currentNumber със стойността на текущия елемент, за да следим новата последователност.
                currentCount = 1;
                currentNumber = numbers[i];
            }
        }

        int[] longestSequence = new int[maxCount];
        for (int i = 0; i < maxCount; i++)
        {
            longestSequence[i] = maxNumber;
        }

        Console.WriteLine(string.Join(" ", longestSequence));
    }
}

