using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Word
    {
        static public bool isPalindrome(string word)
        {
            for (var characterIndex = 0; characterIndex < word.Length / 2; characterIndex++)
            {
                if (char.ToLower(word[characterIndex]) != char.ToLower(word[word.Length - characterIndex - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
