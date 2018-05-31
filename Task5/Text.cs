using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Text
    {
        static public int NumberOfCoincidences(string text, string specialWord)
        {
            string[] wordsInText = text.Split(',', ' ', '.', '!', '?');

            int numberOfCoincidences = 0;

            foreach (string word in wordsInText)
            {
                if (word == specialWord) numberOfCoincidences++;
            }

            return numberOfCoincidences;
        }
    }
}
