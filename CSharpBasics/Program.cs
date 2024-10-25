using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        //function which return the sum of two numbers after scanning in the standard input :
        public static int sum()
        {
            //for the first number enter
            Console.Write("Enter first number : ");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            //for the second number enter
            Console.Write("Enter second number : ");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            return num1 + num2;
        }

        //function which 
        static void Main(string[] args)
        {
            Console.WriteLine("Sum => " + sum());
            Console.ReadLine();
        }
    }
}
