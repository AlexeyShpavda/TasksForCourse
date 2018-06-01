using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            /*
            Создать программу, которая будет сообщать, является ли целое
            число, введенное пользователем, чётным или нечётным, простым
            или составным.  Если пользователь введёт не целое число, то
            сообщать ему об ошибке.
            */

            int number;
            while (true)
            {
                Console.Write("Enter an integer --> ");
                bool isInteger = Int32.TryParse(Console.ReadLine(), out number);
                if (isInteger) break;
                else
                {
                    Console.Write("ERROR!");
                }
            }

            bool isEven = Integer.IsEven(number);
            Console.WriteLine("Is number Even? {0}", isEven);

            bool isPrime = Integer.IsPrime(number);
            Console.WriteLine("Is number Prime? {0}", isPrime);

            Console.ReadKey();
        }
    }
}
