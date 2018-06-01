namespace Task1
{
    class Integer
    {
        public static bool IsEven(int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            else
            {
                for (int divisor = 2; divisor <= number / 2; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
