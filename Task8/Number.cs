using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Number
    {
        static public bool isPalindrome(string number)
        {
            for (var digitIndex = 0; digitIndex < number.Length / 2; digitIndex++)
            {
                if (char.ToLower(number[digitIndex]) != char.ToLower(number[number.Length - digitIndex - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
