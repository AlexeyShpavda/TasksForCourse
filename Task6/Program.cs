using System;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            /*
            Написать программу, которая проверяет три отрезка на возможность
            создать прямоугольный треугольник. Длина отрезков вводится вручную.
            */

            Console.Write("Enter side a --> ");
            double sideA = Double.Parse(Console.ReadLine());

            Console.Write("Enter side b --> ");
            double sideB = Double.Parse(Console.ReadLine());

            Console.Write("Enter side c --> ");
            double sideC = Double.Parse(Console.ReadLine());

            bool existenceOfTriangle = Triangle.Existence(sideA, sideB, sideC);
            Console.WriteLine("Does the triangle exist? {0}", existenceOfTriangle);

            Console.ReadKey();
        }
    }
}
