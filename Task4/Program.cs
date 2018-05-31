using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Создать программу, которая будет подсчитывать количество слов в
            предложении и выводить их в отсортированном виде. Предложение
            вводится вручную. (Разделители пробел (“ ”) и запятая (“,”)).
            */

            Console.Write("Enter the sentence --> ");
            string sentence = Console.ReadLine();
            
            Console.WriteLine("Number of words in sentence -- {0}", Sentence.CountNumberOfWords(sentence));

            Console.WriteLine("Sorted word list:");
            List<string> w = Sentence.sortWords(sentence);
            foreach (string word in w)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
