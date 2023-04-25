using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin8
{
    internal class Program
    {
        private static int bmm(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static void kmm(int a, int b)
        {
            Console.WriteLine(" kmm is "+(a * b) / bmm(a, b) );
        }
        static void Main(string[] args)
        {
            Console.Write(" enter  number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" enter  number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" bmm is " + bmm(num1 , num2));
            kmm(num1, num2);
        }

    }
}
