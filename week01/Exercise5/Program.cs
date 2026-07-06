using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
            DisplayWelcome();

            string name = Promptname();
            int number = Promptnumber();

            int square = Squarenumber(number);

            DisplayFinal(name, square);
    }       
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string Promptname()
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            return name;
        }

                static int Promptnumber()
        {
            Console.Write("Enter your favorite number?: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
            static int Squarenumber(int number)
        {
            int square = number * number;
            return square;

        }

            static void DisplayFinal(string name, int square)
        {
            Console.WriteLine($"{name}, the square value of your number is {square}");
        }

        
    
}