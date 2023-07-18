// See https://aka.ms/new-console-template for more information
using System;

namespace numberGuessing // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Number! type a number from 1 to 10 and press enter!");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            Random computerChoice = new Random();
            int computerNumber = computerChoice.Next(0,10);

            if(guessedNumber == computerNumber)
            {
                Console.WriteLine(guessedNumber + " your number");
                Console.WriteLine(computerNumber+ " computer number");
                Console.WriteLine("congratulations! the number you guessed is right!");

            }
            else
            {
                Console.WriteLine(guessedNumber + " your number");
                Console.WriteLine(computerNumber + " computer number");
                Console.WriteLine("the number is wrong!");
            }

        }
    }
}
