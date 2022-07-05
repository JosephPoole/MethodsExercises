using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); 
            var name = Console.ReadLine(); 
            Console.WriteLine("What is your age?"); 
            var age = Console.ReadLine(); 
            Console.WriteLine("What is your favorite color?"); 
            var color = Console.ReadLine(); 
            Console.WriteLine("Where do you live?"); 
            var location = Console.ReadLine(); 
            Console.WriteLine( $"{name}  is  {age} years old. {name}'s favorite color is {color} and they live in {location}."); 
            
        }
    }
}