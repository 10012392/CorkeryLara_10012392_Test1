//Lara Corkery 
//Question Three
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application Introduction 
            Console.WriteLine("Can You Solve The Following Algebraic Expression:");
            Console.WriteLine("2(x - 3) + x = 12");

            //Declearing the variable for x and equals the value 
            int x = 6;

            //Asks user for their guess 
            Console.Write("Please Enter Your Guess For The Value Of x: ");
            int guess = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            // If Else Statements - calculates if the guess matches the value of x variable
            if (x == guess)
            {
                //If guess was correct 
                Console.WriteLine("Congradulations!! Your Answer Was Correct! ");
            }
            else
            {
                if (guess > x)
                    //If guess was wrong
                    Console.WriteLine("Your Answer Was Incorrect");
                else if (guess < x)
                    Console.WriteLine("Your Answer Was Incorrect");
            }
            Console.WriteLine();

            //Application finished 
            Console.WriteLine("Application Completed, Press [ENTER] To Continue");
            Console.ReadLine();

            //How I calculated the value of x 
            /*2(x + 3) + x = 12 || 2x - 6 + x = 12 || x = 2x - 6 = 12
             = 2x - 12 || x = 6 */ 
        }
    }
}
