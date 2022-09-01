using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises
{
    public class _2_sum
    {
        public static void Main1()
        {
            Console.WriteLine("enter first number and second number");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Sum is " + (num1 + num2));
            Console.ReadKey();
        }
    }
}
