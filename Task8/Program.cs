using System;

namespace Task8
{
    class Program
    {
        static void Main()
        {
            /*
            Написать программу, которая в последовательности от 0 до N,
            находит все числа-палиндромы(зеркальное значение равно
            оригинальному).Длина последовательности вводится вручную и не
            должна превышать 100.
            */

            int sequenceLength;
            while (true)
            {
                Console.Write("Enter sequence length less than 100 --> ");
                bool isInteger = Int32.TryParse(Console.ReadLine(), out sequenceLength);
                if (isInteger && (sequenceLength < 100)) break;
                else
                {
                    Console.Write("ERROR!");
                }
            }

            int[] sequence = new int[sequenceLength];

            for(var indexOfElement = 0; indexOfElement < sequenceLength; indexOfElement++)
            {
                sequence[indexOfElement] = 2 * (indexOfElement + 1) - 1;
            }

            foreach(int el in sequence)
            {
                if (Number.isPalindrome(Convert.ToString(el)))
                {
                    Console.WriteLine(el);
                }
            }

            Console.ReadKey();
        }
    }
}
