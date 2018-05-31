using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
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
