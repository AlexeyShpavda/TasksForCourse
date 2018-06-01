using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать программу, составляющую всевозможные комбинации 3-х
            значных чисел из 3-х введенных пользователем цифр. Цифры
            вводятся вручную.
            */
            int arraySize = 3;
            int[] array = new int[arraySize];
            for (var indexOfElement = 0; indexOfElement < arraySize; indexOfElement++) 
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
