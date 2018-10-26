using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize a random number using Random class;
            Random temp = new Random();
            int randomNumber = temp.Next(1, 100);

            Console.WriteLine("Hello! Guess a number!");
            // have user guess a number and store it
            int userInput = int.Parse(Console.ReadLine());

            // find the difference between the input and the random
            int difference = randomNumber - userInput;

            // int that counts how many guesses it takes, starts at 1 b/c first guess is the first input
            int numberGuesses = 1;

            // if the user's guess isn't right, keep making them guess til they get it right!
            while (userInput != randomNumber)
            {
                // print FREEZING if the number the user guesses is 15 or 
                // more away from the random
                if (difference > 15 || difference < -15)
                {
                    Console.WriteLine("FREEZING! Guess again!");
                }

                // print COLD if the guess is between 6 and 15 away
                else if ((difference <= 15 && difference >= 6) || (difference >= -15 && difference <= -6))
                {
                    Console.WriteLine("COLD! Guess again!");
                }

                // print WARM if the guess is between 2 and 5 away
                else if ((difference <= 5 && difference >= 2) || (difference >= -5 && difference <= -2))
                {
                    Console.WriteLine("WARM! Guess again!");
                }

                // print HOT if the guess is 1 away
                else if (difference == 1 || difference == -1)
                {
                    Console.WriteLine("HOT! Guess again!");
                }

                userInput = int.Parse(Console.ReadLine()); // change userInput to updated guess
                difference = randomNumber - userInput; // change difference to account for updated guess
                numberGuesses++; // increment the guess counter
            }

            // tell them they're lucky if they guess it!
            // three different ways to use variables in strings:
            Console.WriteLine($"Congratulations! It took you {numberGuesses} guesses"); // Dan's favorite
            Console.WriteLine("Congratulations! It took you {0} guesses", numberGuesses);
            Console.WriteLine("Congratulations! It took you " + numberGuesses + " guesses");
        }
    }
}
