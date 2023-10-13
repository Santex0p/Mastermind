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
                // Table of position attemps************
                char[] position = new char[4];
                for (int i = 0; i < position.Length; i++)
                {
                    position[i] = secret[i];
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
                    Console.WriteLine("*******You Win :D*******");
                    // Message of win and option of Re-play
                    choice();
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        break;
                    }
                }
                else
                {
                    // Conditions of lose 
                    for (int y = 0; y < attempts; y++)
                    {
                        Console.Clear();
                        Console.WriteLine("-------You lose :(, Try again-------");

                        // Shows the signs
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (guess[i] == secret[i])
                            {
                                Console.WriteLine("Color " + guess[i] + " is correct");
                            }
                        }
                        // Number of correct positions
                        for (int i = 0; i < position.Length; i++)
                        {
                            if (guess[i] == position[i])
                            {
                                Console.WriteLine("Correct positions:" + position[i]);
                            }
                        }
                            // Attemps
                            attempts--;
                            Console.WriteLine("you have " + (attempts - 7) + " attempts left");

                            // Conditions of the second attempt to win
                            if (Console.ReadLine().ToUpper() == secret)
                            {
                                attempts = 0;
                                Console.WriteLine("*******You Win :D*******");
                                choice();
                                if (Console.ReadLine().ToUpper() == "N")
                                {
                                    break;
                                }
                            }
                        Console.WriteLine("Oh no, You are so bad D:");
                    }
                    // Games to play 
                    played--;
                    Console.WriteLine("You have " + (played - 6) + " games to play, press enter to continue");
                    Console.ReadLine();
                    Console.Clear();

                }
                void choice()
                {
                    Console.WriteLine("You want to play again [y/n]?");
                }
                /*void seconds()
                {
                    var timer = new stopwatch();
                    timer.Start();
                    for (int i = 0; i < 1000000000; i++)
                    {
                        int x = i * i + 1;
                    }
                    timer.Stop();

                    TimeSpan timeTaken = timer.Elapsed;
                    string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
                    Console.WriteLine(foo);
                }*/

            }
        }
    }
}
