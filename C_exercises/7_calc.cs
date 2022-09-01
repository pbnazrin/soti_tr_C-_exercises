using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises
{
    public class _calc
    {
        public static void Main1()
        {
            Console.WriteLine("enter first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            double num2 = double.Parse(Console.ReadLine());
           

            Console.WriteLine(num1+" + "+num2+ " = "+ (num1+num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            if (num2 != 0)
            {
                Console.WriteLine(num1 + " + " + num2 + " = " + Math.Floor(num1 / num2));
            }
            else
            {
                Console.WriteLine("Division can't be performed");
            }
            Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2));



            Console.ReadKey();
        }
    }
}
