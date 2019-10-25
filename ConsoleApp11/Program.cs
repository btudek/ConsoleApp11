using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "liberal";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("What word use to represet individual rights but now represets feelings?");
                    guess = Console.ReadLine();
                    guessCount++;
                    if (guessCount < 2 && guess != secretWord)
                    {
                        Console.WriteLine("Close?");
                        Console.WriteLine("1 guess down 2 to go.");
                    }
                    else if (guessCount < 3 && guess != secretWord)
                    {
                        Console.WriteLine("You got this, i think");
                        Console.WriteLine("Last Chance");

                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }



            }
            if (outOfGuesses && guess != secretWord)

            {
                Console.WriteLine("You lose.");

            }
            else

            {
                Console.WriteLine("Correct!");
                Console.WriteLine("Look at you and your large penis genius!");
            }




            Console.ReadLine();
        }
    }
}

