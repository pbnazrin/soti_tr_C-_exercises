using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises
{
  
    public class _10_cal
    {
        public static void Main1()
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(" (x+y).z = " + (num1+num2)*num3);
            Console.WriteLine(" x.y+y.z = " + ((num1 * num2) +(num2*num3)));

            Console.ReadKey();

        }
    }
}
