using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать программу, которая в последовательности от 0 до N,
            находит все числа-палиндромы(зеркальное значение равно
            оригинальному).Длина последовательности вводится вручную и не
            должна превышать 100.
            */
            int sizeOfArray;
            while (true)
            {
                Console.Write("Enter an integer less than 100 --> ");
                bool isInteger = Int32.TryParse(Console.ReadLine(), out sizeOfArray);
                if (isInteger && (sizeOfArray < 100)) break;
                else
                {
                    Console.Write("ERROR!");
                }
            }

            int[] array = new int[sizeOfArray];

            for(var indexOfElement = 0; indexOfElement < sizeOfArray; indexOfElement++)
            {
                array[indexOfElement] = 2 * (indexOfElement + 1) - 1;
            }

            foreach(int el in array)
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
