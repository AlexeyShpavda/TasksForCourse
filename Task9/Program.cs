using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать программу выводящую на экран все четные числа и их 
            сумму из последовательности от 0 до N. N вводится вручную.
            */

            Console.Write("Enter the length of the sequence --> ");
            int lengthOfSequence = Int32.Parse(Console.ReadLine());

            int[] array = new int[lengthOfSequence];

            for (var indexOfElement = 0; indexOfElement < lengthOfSequence; indexOfElement++)
            {
                array[indexOfElement] = indexOfElement + 1;
            }

            int sumOfEvenNumbers = 0;
            for (var indexOfElement = 0; indexOfElement < lengthOfSequence; indexOfElement++)
            {
                if (array[indexOfElement] % 2 == 0)
                {
                    Console.WriteLine(array[indexOfElement]);
                    sumOfEvenNumbers += array[indexOfElement];
                }
            }
            Console.WriteLine("The sum of even numbers in the sequence - {0}", sumOfEvenNumbers);
            Console.ReadKey();
        }
    }
}
