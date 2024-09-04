//9. Write a C# Sharp program that takes the radius of a circle as input and
//calculates the perimeter and area of the circle.

using System;

namespace Class12VPLab
{
    public class Q9
    {
        public static void Cicle()
        {
            Console.Write("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * 3.14 * radius;
            double area = 3.14 * radius * radius;

            Console.WriteLine("Perimeter of circle: " + perimeter);
            Console.WriteLine("Area of circle: " + area);
        }
    }
}
