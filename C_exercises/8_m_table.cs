using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises
{
    public class _8_m_table
    {
        public static void Main1()
        {
            Console.WriteLine("enter the number");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num1 + " * " + i + " = " + (num1 * i));
            }
            Console.ReadKey();
            
        }
    }
}
