using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($" Hello {name}.Enter two numbers you'd like to add together.");
            var result = Add();
            Console.WriteLine(result);
            Console.WriteLine($" Hello {name}.Enter two numbers you'd like to subtract from the other.");
            var result2 = Subtract();
            Console.WriteLine(result2);
            Console.WriteLine($"hello {name}. Enter two numbers you'd like to Multiply.");
            var result3 = Multiply();
            Console.WriteLine(result3);
            Console.WriteLine($"hello {name}. Enter two numbers that you'd like to divide the first by the second.");
            var result4 = Divide();
            Console.WriteLine(result4);

        }

        public static int Add()
        {
            int num1 = 0;

            Int32.TryParse(Console.ReadLine(), out num1);
            int num2 = 0;

            Int32.TryParse(Console.ReadLine(), out num2);

            return num1 + num2;
        }
        public static int Subtract()
        {
            int num1 = 0;

            Int32.TryParse(Console.ReadLine(), out num1);
            int num2 = 0;

            Int32.TryParse(Console.ReadLine(), out num2);

            return num1 - num2;
        }
        public static int Multiply()
        {
            int num1 = 0;

            Int32.TryParse(Console.ReadLine(), out num1);
            int num2 = 0;

            Int32.TryParse(Console.ReadLine(), out num2);

            return num1 * num2;
        }
        public static int Divide()
        {
            int num1 = 0;

            Int32.TryParse(Console.ReadLine(), out num1);
            int num2 = 0;

            Int32.TryParse(Console.ReadLine(), out num2);

            return num1 / num2;
        }
    }
}

        

    
