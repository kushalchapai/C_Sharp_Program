
//8. Write a C# Sharp program that takes three letters and displays them in reverse order.
using System;

namespace Class12VPLab
{
    public class Q8
    {
        public static void Reverse()
        {
            Console.WriteLine("Input three letters: ");

            char letter = Convert.ToChar(Console.ReadLine());
            char letter1 = Convert.ToChar(Console.ReadLine());
            char letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
        }
    }
}
