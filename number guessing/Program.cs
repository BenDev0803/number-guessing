// See https://aka.ms/new-console-template for more information
using System;

namespace numberGuessing // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Number! type a number and press enter!");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
