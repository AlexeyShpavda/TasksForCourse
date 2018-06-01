using System;
using System.Linq;

namespace Task7
{
    class Program
    {
        static void Main()
        {
            /*
            Написать программу, которая рандомно генерирует массив 2-ух
            значных чисел длины N(вводится вручную) и выводит наименьшее и
            наибольшее число из списка.
            */

            Console.Write("Enter the size of the array --> ");
            int sizeOfArray = Int32.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];

            Random random = new Random();

            for (var arrayElementIndex = 0; arrayElementIndex < sizeOfArray; arrayElementIndex++)
            {
                array[arrayElementIndex] = random.Next(10, 99);
            }

            //for (var arrayElementIndex = 0; arrayElementIndex < sizeOfArray; arrayElementIndex++)
            //{
            //    Console.Write("{0} ", array[arrayElementIndex]);
            //}

            Console.WriteLine("\nMax - {0}", array.Max());
            Console.WriteLine("Min - {0}", array.Min());

            Console.ReadKey();
        }
    }
}
