/*5. Write a C# Sharp program to swap two numbers.*/


using System;

namespace Class12VPLab
{
    public class Q5
    {
        public static void Swap()
        {
            int a = 2; int b = 3;
            int temp = a;
            Console.WriteLine("Value before swapping of num1 "+a);
            Console.WriteLine("Value before swapping of num2 "+b);


            a = b; 
            b =temp;

            Console.WriteLine("Value after swapping of num1 " + a);
            Console.WriteLine("Value after swapping of num2 " + b);



        }
    }
}
