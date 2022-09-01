using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises
{
    public class _5_swap
    {
        public static void Main1()
        {
             void swap(double a,double b)
            {
                 a = a + b;
                Console.WriteLine("a" + a);
                 b = a - b;
                Console.WriteLine("b" + b);
                a = (a - b) ;
                
                Console.WriteLine("Numbers before swapping-num1 is " + a + " and num2 is " + b);

            }
            Console.WriteLine("Enter the first number ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Numbers before swapping-num1 is " + num1 + " and num2 is " + num2);
            swap(num1, num2);

            Console.ReadKey();
        }
    }
}
