using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_2ndexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            var num2 = int.Parse(Console.ReadLine());

            int total = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);

            Console.ReadLine();
        }
    }
}
