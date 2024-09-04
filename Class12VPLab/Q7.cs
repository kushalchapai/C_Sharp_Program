/*7. Write a C# Sharp program to print on screen the output of adding,
subtracting, multiplying and dividing two numbers entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
*/
using System; 

namespace Class12VPLab
{
    public class Q7
    {
        
        public void Arithmetic()
        {
            Console.Write("Input the first number: ");
            
            
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            int add = num1 + num2;
            int subtract = num1 - num2;
            int multiply = num1 * num2;
            int divide = num1 / num2;
            int mod = num1%num2;

            Console.WriteLine("Excepted Output: ");

            Console.WriteLine("" + num1 + "+" + num2 + "=" + add);
            Console.WriteLine("" + num1 + "-" + num2 + "=" + subtract);
            Console.WriteLine("" + num1 + "*" + num2 + "=" + multiply);
            Console.WriteLine("" + num1 + "/" + num2 + "=" + divide);
            Console.WriteLine("" + num1 + "%" + num2 + "=" + mod);
        } 
    }
}
