using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            int guessLimit = 3;
            int guessChance = 0;
            int guess = 0;
            int level = 0;

            
            Console.WriteLine("WELCOME TO GOLDEN'S LUCKY NUMBER");
            Console.WriteLine("");
            Console.WriteLine("Select 1 for Easy mood");
            Console.WriteLine("Select 2 for Medium mood");
            Console.WriteLine("Select 3 for Hard mood");
            Console.WriteLine("");
            Console.Write("Please choose the level: ");
            level = int.Parse(Console.ReadLine());

            int[] levelOptions = {1, 2, 3};
            
            int[] guessOptionsOne = {1,2,3,4,5,6,7,8,9,10};
            int[] guessOptionsTwo = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int[] guessOptionsThree = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,
                                26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50};

                if(level == levelOptions[0])
                {
                    Console.WriteLine("GOLDEN'S LUCKY NUMBER (EASY)");
                    Console.WriteLine("You have 6 chances to guess the right number");
                    Console.WriteLine("Please select a number between 1 and 10");
                    guessLimit = 6;
                    int guessLeft = 6;
                    while(guessChance < guessLimit)
                    {
                        Console.WriteLine("");

                        // display this if user inputs non-numeric
                        try
                        {
                            Console.Write("Make a guess: ");
                            guess = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("What you chose is not a number");
                        }
                        
                        if(guess == guessOptionsOne[3])
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else if(guess < guessOptionsOne[0])
                        {
                            Console.WriteLine("Please choose a number between 1 and 10");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                        else if(guess > guessOptionsOne[9])
                        {
                            Console.WriteLine("Please choose a number between 1 and 10");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                        else if(guess != guessOptionsOne[3])
                        {
                            Console.WriteLine("That was wrong");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                    }
                    // display this once the user makes 6 wrong guesses
                    if(guessChance >= guessLimit)
                    Console.WriteLine("Game over!");
                
                }

                if(level == levelOptions[1])
                {
                    Console.WriteLine("GOLDEN'S LUCKY NUMBER (MEDIUM)");
                    Console.WriteLine("You have 4 chances to guess the right number");
                    Console.WriteLine("Please select a number between 1 and 20");
                    guessLimit = 4;
                    int guessLeft = 4;
                    while(guessChance < guessLimit)
                    {
                        Console.WriteLine("");

                        // display this if user inputs non-numeric
                        try
                        {
                            Console.Write("Make a guess: ");
                            guess = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("What you chose is not a number");
                        }
                        
                        if(guess == guessOptionsTwo[14])
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else if(guess < guessOptionsTwo[0])
                        {
                            Console.WriteLine("Please choose a number between 1 and 20");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                        else if(guess > guessOptionsTwo[19])
                        {
                            Console.WriteLine("Please choose a number between 1 and 20");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                        else if(guess != guessOptionsTwo[14])
                        {
                            Console.WriteLine("That was wrong");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                    }
                    // display this once the user makes 4 wrong guesses
                    if(guessChance >= guessLimit)
                    Console.WriteLine("Game over!");
                
                }

                // if user chooses a number not in levelOptions, display hard level automatically
                if(level >= levelOptions[2] || level < levelOptions[0])
                {
                    Console.WriteLine("GOLDEN'S LUCKY NUMBER (HARD)");
                    Console.WriteLine("You have 3 chances to guess the right number");
                    Console.WriteLine("Please select a number between 1 and 50");
                    guessLimit = 3;
                    int guessLeft = 3;
                    while(guessChance < guessLimit)
                    {
                        Console.WriteLine("");

                        // display this if user inputs non-numeric
                        try
                        {
                            Console.Write("Make a guess: ");
                            guess = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("What you chose is not a number");
                        }
                        
                        if(guess == guessOptionsThree[40])
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else if(guess < guessOptionsThree[0])
                        {
                            Console.WriteLine("Please choose a number between 1 and 50");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                        else if(guess > guessOptionsThree[49])
                        {
                            Console.WriteLine("Please choose a number between 1 and 50");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                        else if(guess != guessOptionsThree[40])
                        {
                            Console.WriteLine("That was wrong");
                            guessChance += 1;
                            guessLeft -= 1;
                            if(guessLeft == 1)
                            {
                                Console.WriteLine($"You have {guessLeft} guess left");
                            }
                            else if(guessLeft == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"You have {guessLeft} guesses left");
                            }
                        }
                    }
                    // display this once the user makes 3 wrong guesses
                    if(guessChance >= guessLimit)
                    Console.WriteLine("Game over!");
                
                }
            }
        }
    }
}
