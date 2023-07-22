/*
 * Description: This game involves a secret number being chosen by the computer within a specific range (let’s say 1-100) 
 * and the player then tries to guess this number.

If the number they guess is too low, the program will say “too low” and if it is too high it will reply with “too high”. 
The player wins when they guess the correct number.
Tips: First thing to look at is generating a random number. 
Despite the language you choose, most of the time a random number can be created using a random generator function or object.
.NET has the “Random” object and C++ has rand().
Once you have a random number chosen, ask the player for a guess.
Compare their guess to this random number chosen. An easy if statement can be used to see if it is too high or too low. 
If they are equal, tell the player they win and restart the game.
Added Difficulty: Put a limit on how many wrong guesses they can have. Too many and the game ends with “You lose”.



Here’s how other people have solved the previous exercise:

https://download.rak.dev/examples/02_ReverseString_olaf.zip
*/

// See https://aka.ms/new-console-template for more information
using System;

namespace numberGuessing // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static readonly Random computerChoice = new Random();
        static void Main(string[] args)
        {
            const int rangeNumber = 101;
            const int attempts = 7;
            int computerNumber = computerChoice.Next(0, rangeNumber);
            for (int i = attempts; i >= 1; i--)
            {
                Console.WriteLine($"Guess the Number! type a number from 1 to 100 and press enter! you have {i} attempts!");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());
                
                if (guessedNumber == computerNumber)
                {
                    Console.WriteLine($"{guessedNumber} your number");
                    Console.WriteLine("congratulations! the number is correct!");
                    break;
                }

                if (i == 1 && guessedNumber != computerNumber)
                {
                    Console.WriteLine("you lose");
                }
                
                if ((guessedNumber >= computerNumber))
                {
                    Console.WriteLine("too high");
                }

                if (guessedNumber <= computerNumber)
                {
                    Console.WriteLine($"{guessedNumber} your number");
                    Console.WriteLine(" too low!");
                }

                if (((guessedNumber >= (computerNumber - 5)) && (guessedNumber <= (computerNumber + 5))))
                {
                    Console.WriteLine("you're close!");
                }
            }
        }
    }
}
