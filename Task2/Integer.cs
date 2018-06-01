using System;

namespace Task2
{
    class Integer
    {
        static public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        static public int Difference(int number1, int number2)
        {
            return number1 - number2;
        }

        static public int Nod(int number1, int number2)
        {
            if (number2 < 0) number2 = -number2;
            if (number1 < 0) number1 = -number1;

            while (number2 > 0)
            {
                int temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }
            return number1;
        }
        static public int Nok(int number1, int number2)
        {
            return Math.Abs(number1 * number2) / Nod(number1, number2);
        }
    }
}
