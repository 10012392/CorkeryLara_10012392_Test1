//Lara Corkery
//Question Two 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application Introduction 
            Console.WriteLine("This Application Will Calculate The Sum Of 5 Prices");
            //Declearing Variable 
            double total = 0;

            //For Loop - Asking the user to input the values and the calculation
            for (int i = 1; i<=5; i++)
            {
                Console.Write($"Please Enter The Price Of Item {i}: ");
                total = total + double.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");

            //Output result 
            Console.WriteLine($"The Total Of Those 5 Items is: ${total}0");

            //Application finished
            Console.WriteLine("Application Completed, Press [ENTER] To Continue.");
            Console.ReadLine();

        }
    }
}
