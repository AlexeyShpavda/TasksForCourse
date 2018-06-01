using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            /*
            Создать программу, которая будет вычислять и выводить на экран 
            сумму, разность, НОК и НОД двух целых чисел, введенных 
            пользователем. Если пользователь некорректно введёт хотя бы одно
            из чисел, то сообщать об ошибке.
            */

            int[] numbers = new int[2];
            string[] words = new string[] { "first", "second" };

            for (int elementIndex = 0; elementIndex < numbers.Length; elementIndex++) 
            {
                while (true)
                {
                    Console.Write("Enter {0} integer --> ", words[elementIndex]);
                    bool isInteger = Int32.TryParse(Console.ReadLine(), out int number);
                    if (isInteger)
                    {
                        numbers[elementIndex] = number;
                        break;
                    }
                    else
                    {
                        Console.Write("ERROR!");
                    }
                }
            }

            int sum = Integer.Sum(numbers[0], numbers[1]);
            Console.WriteLine("Sum = {0}", sum);

            int difference = Integer.Difference(numbers[0], numbers[1]);
            Console.WriteLine("Difference = {0}", difference);

            int nod = Integer.Nod(numbers[0], numbers[1]);
            Console.WriteLine("Nod = {0}", nod);

            int nok = Integer.Nok(numbers[0], numbers[1]);
            Console.WriteLine("Nok = {0}", nok);

            Console.ReadKey();
        }
    }
}
