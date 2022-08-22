using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment
    {
        public static void Main()
        {
            int num1, num2, num3;

            Console.Write("Feed the first number to calculate product : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Feed the second number to calculate product: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Feed the third number to calculate product : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine(result);
        }
    }
}
