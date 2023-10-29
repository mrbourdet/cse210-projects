using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        string continueFlag = "Y";
        do
        {
            // Choose Magic Number
            Random randomGenerator = new Random();
            int numericMagicNumber = randomGenerator.Next(1, 11);
            // Console.WriteLine(numericMagicNumber);
            string guess;
            int numericGuess = 0;

            int count = 1;        
            while (numericGuess != numericMagicNumber)
            {            
                Console.Write("Please enter a guess ");
                guess = Console.ReadLine();
                numericGuess = int.Parse(guess);
                if (numericGuess > numericMagicNumber)
                {
                    Console.WriteLine("Guess lower.");
                    count++;
                }
                else if (numericGuess < numericMagicNumber)
                {
                    Console.WriteLine("Guess higher.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {count} guesses!");
                }
            }
            Console.Write("Do you want to continue? Y/N ");
            continueFlag = Console.ReadLine();
        } while (continueFlag.ToLower() == "y");
        Console.WriteLine("Thanks for playing.");
    } 
}
/* 
Core Requirements
  
Instead of having the user supply the magic number, generate a random number from 1 to 100.

Play the game and make sure it works!

Stretch Challenge
Keep track of how many guesses the user has made and inform them of it at the end of the game.

After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
*/