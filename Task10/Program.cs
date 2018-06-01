using System;

namespace Task10
{
    class Program
    {
        static void Main()
        {
            /*
            Написать программу, составляющую всевозможные комбинации 3-х
            значных чисел из 3-х введенных пользователем цифр. Цифры
            вводятся вручную.
            */

            Console.Write("Enter the number of digit for combinations --> ");
            int numberOfDigit = Int32.Parse(Console.ReadLine());
            //int numberOfDigit = 3;

            int[] array = new int[numberOfDigit];
            for (var indexOfElement = 0; indexOfElement < numberOfDigit; indexOfElement++) 
            {
                Console.Write("Enter {0} digit --> ", indexOfElement + 1);
                array[indexOfElement] = Int32.Parse(Console.ReadLine());
            }

            cycle(array, 0);

            Console.ReadKey();
        }

        public static void cycle(int[] array, int counter)
        {
            int i;
            if (counter >= array.Length - 1)
            {
                for (i = 0; i < array.Length; ++i)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (i = counter; i < array.Length; ++i)
                {
                    int temp = array[i];
                    array[i] = array[counter];
                    array[counter] = temp;
                    cycle(array, counter + 1);
                    temp = array[i];
                    array[i] = array[counter];
                    array[counter] = temp;
                }
            }
        }
    }
}
