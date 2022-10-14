using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashain_Task.Calculator
{
    internal class Calculator
    {
        public static void Addition(int num1, int num2)
        {
            Console.WriteLine($"The result of Addition is: {num1} + {num2} = " +(num1 + num2));
        }

        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine($"The result of Subtraction is: {num1} - {num2} = " + (num1 - num2));
        }

        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"The result of Multiplication is: {num1} X {num2} = " + (num1 * num2));
        }

        public static void Division(int num1, int num2)
        {
            Console.WriteLine($"The result of addition is: {num1} / {num2} = " + (num1 / num2));
        }
    }
}
