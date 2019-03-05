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
            //Asks the user to enter a number. The number chosen by the user will be saved as a variable.
            Console.WriteLine("Please enter a number: ");
            var num1 = int.Parse(Console.ReadLine());

            //a second number is requested by the program from the user. This will also be stored in a variable.
            Console.WriteLine("Enter another number: ");
            var num2 = int.Parse(Console.ReadLine());

            //This creates a new variable named total then registers the 2 variables as the 2 if they are added together.
            int total = num1 + num2;
            
            //adds the 2 variables and stores the result in the total variable then displays it to the user.
            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);

            Console.ReadLine();
        }
    }
}
