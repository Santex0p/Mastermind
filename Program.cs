using System;

namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random for the combination of colors
            Random random = new Random();
            bool exit = false;


            // Table (dont work now)
            string name;

            // Welcome of player with his name and ask if you want to play 
            Console.WriteLine("*****************");
            Console.WriteLine("Mastermind Game");
            Console.WriteLine("*****************");
            Console.WriteLine("");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + ".");
            int played = 17;

            bool gameOver = false;

            // Base of the game 
            for (int gameCount = 0; gameCount < 10 && gameOver==false; gameCount++)
            {
                Console.WriteLine("*****Game start!******");

                /* Is the character used to initialize the string
                   in the while loop to ensure that no more than 4 letters are generated */
                string secret = "";

                // Random combination of "RGBY" 
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(4);
                    if (x == 0)
                    {
                        secret = secret + 'R';
                    }
                    else if (x == 1)
                    {
                        secret = secret + 'G';
                    }
                    else if (x == 2)
                    {
                        secret = secret + 'B';
                    }
                    else if (x == 3)
                    {
                        secret = secret + 'Y';
                    }

                }

                // Secret Combination 
                Console.WriteLine($"secret is {secret}");

                //Attemps of loses and of Games played 
                int attempts = 17;

                // Instructions 
                Console.WriteLine("You need to find the secret color combination with the letters:");
                Console.WriteLine("R-G-B-Y");

                // Attempt variable
                string guess = Console.ReadLine().ToUpper();

                // Conditions of Win
                if (guess == secret)
                {
                    Console.WriteLine("*******Congrats " + name + " You Win :D*******");
                    // Message of win and option of Re-play
                    choice();
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Good choice!");
                    }
                }
                else
                {
                    // Conditions of lose 
                    for (int y = 0; y < attempts; y++)
                    {
                        Console.Clear();
                        Console.WriteLine("-------You lose :( " + name + ", Try again-------");

                        // Shows the signs
                        int correctPositions = 0;
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (guess[i] == secret[i])
                            {
                                Console.WriteLine("Color " + guess[i] + " is correct");
                                correctPositions++;
                            }
                        }
                       
                        Console.WriteLine("Correct Positions: " + correctPositions);
                        // Attemps
                        attempts--;

                        Console.WriteLine("you have " + (attempts - 7) + " attempts left");

                        // Conditions of the second attempt to win
                        Console.Write("try again:");
                        guess = Console.ReadLine().ToUpper();
                        if (guess.ToUpper() == secret)
                        {
                            attempts = 0;
                            Console.WriteLine("*******You Win :D*******");
                            choice();
                            if (Console.ReadLine().ToUpper() != "Y")
                            {
                                gameOver = true;
                            }
                            break;

                        }
                           
                    }
                    if (guess.ToUpper() != secret)
                    {
                        Console.WriteLine("Oh no " + name + ", You are so bad D:");
                    }

                    if(!gameOver)
                    {
                        // Games to play 
                        played--;
                        Console.WriteLine("You have " + (played - 7) + " games to play, press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Bye bye");
                        Console.ReadLine();
                    }

                    

                }
                void choice()
                {
                    Console.WriteLine("You want to play again [y/n]?");
                }

            }
        }
    }
}
