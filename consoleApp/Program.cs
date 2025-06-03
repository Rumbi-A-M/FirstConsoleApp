using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74740_RumbidzaiAudreyMateke_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput, num1, num2, total;
            Console.WriteLine("WELCOME TO MY PROGRAM");
            Console.WriteLine("=====================");

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please choose one of the options below");
            Console.WriteLine();
           
            Console.WriteLine("1. Developer's name's three letter");
            Console.WriteLine("2.Addition");
            Console.WriteLine("3. Absolute value of the subtraction");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Exit");

            Console.WriteLine();
            Console.Write("Please Write your option: [ ]\b\b");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (userInput == 1)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("My name's first three letter");
                Console.WriteLine();

                Console.WriteLine("RRRRRR  UU  UU   MMMM  MMM");
                Console.WriteLine("RR  RR  UU  UU   MM  MM MM");
                Console.WriteLine("RRRRR   UU  UU   MM     MM");
                Console.WriteLine("RR  RR  UU  UU   MM     MM");
                Console.WriteLine("RR  RR    UU     MM     MM");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("THANK YOU and GOOD BYE");
                Console.WriteLine();
            }
            else if (userInput == 2)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;

                Console.Write("Please enter you first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Please enter your second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                total = num1 + num2;
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Total of {0} and {1} is {2}", num1, num2, total);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("THANK YOU and GOOD BYE");
            }
            else if (userInput == 3)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Please enter you first number:  ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Please enter your second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (num1 > num2)
                {

                    total = num1 - num2;
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine("Subtraction  of {0} and {1} is {2}", num1, num2, total);
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("THANK YOU and GOOD BYE");
                }
                else
                {

                    total = num2 - num1;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Subtraction of {0} and {1} is {2}", num2, num1, total);
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("THANK YOU and GOOD BYE");
                }
            }
            else if (userInput == 4)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;

                Console.Write("Please enter you first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Please enter your second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                total = num1 * num2;
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Multiplication of {0} and {1} is {2}", num1, num2, total);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("THANK YOU and GOOD BYE");
            }
            else if (userInput == 5)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("THANK YOU and GOOD BYE");

            }
            else
            {
                Console.BackgroundColor= ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("you entered something other than a menu number");
            }

        }
    }
}

       
