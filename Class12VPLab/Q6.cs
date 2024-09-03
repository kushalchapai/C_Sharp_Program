//6. Write a C# Sharp program to print the output of the multiplication of three
//numbers entered by the user
using System;

namespace Class12VPLab
{
    public class Q6
    {
        public void Multiplication()
        {
            Console.WriteLine("Enter first number: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mul = num1 * num2 * num3;

            Console.WriteLine("The multiplication is : "+mul);

        }
 
       
 
    }
}