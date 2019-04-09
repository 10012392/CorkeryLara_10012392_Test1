//Lara Corkery 
//Question One 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program Introduction 
            Console.WriteLine("This Application Can Calculate the Result of Base^Exponent ");

            //Program asking the user for base and exponent values
            Console.Write("Please Enter The Value Of The Base: ");
            double base1 = double.Parse(Console.ReadLine());
            Console.Write("Please Enter The Value Of The Exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            //Calculation of the values 
            double total = base1 * exponent;
            double result = total * exponent / base1 + base1 + exponent;
            

            

            //Output of Result 
            Console.WriteLine($"{base1} ^ {exponent} = {result}");

            //Program is finished 
            Console.WriteLine("Program Is Completed, Press [ENTER] To Continue: ");
            Console.ReadLine();

        }
    }
}
