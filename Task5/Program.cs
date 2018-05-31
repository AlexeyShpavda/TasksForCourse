using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Создать программу, которая подсчитывает сколько раз
            употребляется слово в тексте(без учета регистра).Текст и слово
            вводится вручную.
            */
            Console.Write("Enter the text --> ");
            string text = Console.ReadLine();

            Console.Write("Enter the special word for counting --> ");
            string specialWord = Console.ReadLine();

            int numberOfCoincidences = Text.NumberOfCoincidences(text, specialWord);

            Console.WriteLine("{0} times the word was found in the text", numberOfCoincidences);

            Console.ReadKey();
        }
    }
}
