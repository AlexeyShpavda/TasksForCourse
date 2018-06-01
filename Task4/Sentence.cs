using System.Collections.Generic;

namespace Task4
{
    class Sentence
    {
        static public int CountNumberOfWords(string sentence)
        {
            return sentence.Split(',', ' ').Length;
        }

        static public List<string> sortWords(string sentence)
        {
            List<string> words = new List<string>();

            words.AddRange(sentence.Split(',', ' '));
            words.Sort();

            return words;
        }
    }
}
