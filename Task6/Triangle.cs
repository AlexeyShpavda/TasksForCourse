namespace Task6
{
    class Triangle
    {
        static public bool Existence(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB > sideC && 
                sideA + sideC > sideB && 
                sideB + sideC > sideA) return true;
            else return false;
        }
    }
}
