using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises
{
    public class _multiply
    {
        public static void Main1()
        {
            Console.WriteLine("enter first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            double num3 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Result is " + (num1 * num2*num3));
           
            

            Console.ReadKey();
        }
    }
}
