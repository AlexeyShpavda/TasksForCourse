using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            /*
            Необходимо написать программу, которая проверяет слово на 
            "палиндромность".Слово для проверки вводится вручную во время
            выполнения программы.
            */

            string word = Console.ReadLine();

            Console.WriteLine("Is it a palindrome? {0}", Word.isPalindrome(word));

            Console.ReadKey();
        }
    }
}
