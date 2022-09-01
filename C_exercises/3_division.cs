using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises
{
    public class _3_division
    {
        public static void Main1()
        {
            Console.WriteLine("enter first number and second number");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            if (num2 != 0) 
            {
                Console.WriteLine("Division is " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Division by zero is not possible");

            }
            
            Console.ReadKey();
        }
    }
}
