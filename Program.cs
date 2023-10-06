using System;

namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random for the combination of colors
            Random random = new Random();


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

            // Base of the game 
            for (int r = 0; r < 10; r++)
            {
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
                string guess = Console.ReadLine().ToUpper();

                // Conditions of Win
                    if (guess == secret)
                    {
                    // Message of win and option of Re-play
                        choice();
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        break;
                    }
                    // Message of Warning
                        else
                    {
                        Console.WriteLine("Isn't an option. If you do not choose an option the game will close.");
                        choice();
                        if (Console.ReadLine().ToUpper() == "Y")
                        {
                            Console.WriteLine("Good Game!");
                        }
                        else
                        {
                            break;
                        }
                    }
                    }
                    else
                    {
                        // Conditions of lose 
                        for (int y = 0; y < 10; y++)
                        {
                            // Shows the signs
                            for (int i = 0; i < guess.Length; i++)
                            {
                                if (guess[i] == secret[i])
                                {
                                    Console.WriteLine("symbol " + guess[i] + " is correct");
                                }
                            }

                            // Attemps
                            Console.WriteLine("You lose :(");
                            attempts--;
                            Console.WriteLine("you have " + (attempts - 6) + " attempts left");
                            Console.ReadLine();
                        }
                        // Games to play 
                        played--;
                        Console.WriteLine("You have " + (played - 6) + " games to play");
                    }


                    void choice()
                {
                    Console.WriteLine("You want to play again [y/n]?");
                }

                }
            }
        }
    }
