using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "liberal";
            string cheat = "God";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            bool playAgain = true;
            int intPlayAgain = 0;
            



            do
            {
                while (guess != secretWord && !outOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("INSTRUCTIONS");
                        Console.WriteLine("Answer is all lower case.");
                        Console.WriteLine("");
                        Console.WriteLine("INFORMATION");
                        Console.WriteLine("Answers diplayed in Blue");
                        Console.WriteLine(guessCount + " of 3");
                        Console.WriteLine("");
                        Console.WriteLine("QUESTION!");
                        Console.WriteLine("What word use to represet individual rights but now represets feelings?");
                        //Make User Input Blue Color
                        Console.ForegroundColor = ConsoleColor.Blue;
                        guess = Console.ReadLine();
                        guessCount++;

                        //Cheat
                        if (guess == cheat)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("Cheat Activated");
                            Console.WriteLine("The Answer is liberal");
                            Console.WriteLine("");
                            guessCount--;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(guessCount + " of 3");

                        }

                        //Less Than 2 Guesses
                        else if (guessCount < 2 && guess != secretWord && guess != cheat)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("Close?");
                            Console.WriteLine(guessCount + " of 3");
                            Console.WriteLine("");
                        }

                        //Less Than 3 Guesses
                        else if (guessCount < 3 && guess != secretWord && guess != cheat)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("You got " + "this, i think");
                            Console.WriteLine("Last Chance");
                            Console.WriteLine(guessCount + " of 3");
                            Console.WriteLine("");
                        }

                        //Out of Guesses
                        else
                        {
                            outOfGuesses = true;
                        }


                    }
                }
                //Lose
                if (outOfGuesses && guess != secretWord && guess != cheat)

                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You lose.");
                    Console.WriteLine("");
                    guessCount = 0;
                    outOfGuesses = false;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Play again? 1 for Yes|2 for No");
                   


                }
                //Win
                if (secretWord == guess)

                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Correct!");
                    Console.WriteLine("Look at you and your large penis genius!");
                    Console.WriteLine("");
                    guessCount = 0;
                    outOfGuesses = false;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Play again? 1 for Yes|2 for No");
                    



                }












                Console.ReadLine();
            } while (playAgain);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thanks for playing");
        }
    }
}

