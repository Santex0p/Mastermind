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

            // Welcome of player with his name and ask if you want to play //
            Console.WriteLine("*****************");
            Console.WriteLine("Mastermind Game");
            Console.WriteLine("*****************");
            Console.WriteLine("");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + ".");
            Console.WriteLine("Do you wanna play? [y]");

            while (Console.ReadLine() == "y")
            {
                /* Is the character used to initialize the string
                   in the while loop to ensure that no more than 4 letters are generated */ 
                string secret = "";

                // Random combination of "RGBY" //
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
                // Secret Combination //
                Console.WriteLine($"secret is {secret}");
                int attempts =15;
                for (int x = 0; x < attempts; x++)
                {
                    // Instructions // 
                    Console.WriteLine("You need to find the secret color combination with the letters:");
                    Console.WriteLine("R-G-B-Y");
                    string guess = Console.ReadLine();

                    // Conditions win or lose //

                    if (guess == secret)
                    {
                        Console.WriteLine("********");
                        Console.WriteLine("You Win!");
                        Console.WriteLine("********");
                        Game();
                    }
                    else
                    {
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if(guess[i] == secret[i])
                            {
                                Console.WriteLine("symbol "+ guess[i] + " is correct");
                            }
                        }

                        Console.WriteLine("You lose :(");
                    }
                    attempts--;
                    Console.WriteLine("you have " + (attempts - 6) + " attempts left");

                    void Game()
                    {
                        Console.WriteLine($"secret is {secret}");
                        int attempts = 15;
                        for (int x = 0; x < attempts; x++)
                        {
                            // Instructions // 
                            Console.WriteLine("You need to find the secret color combination with the letters:");
                            Console.WriteLine("R-G-B-Y");
                            string guess = Console.ReadLine();

                            // Conditions win or lose //

                            if (guess == secret)
                            {
                                Console.WriteLine("********");
                                Console.WriteLine("You Win!");
                                Console.WriteLine("********");

                            }
                            else
                            {
                                for (int i = 0; i < guess.Length; i++)
                                {
                                    if (guess[i] == secret[i])
                                    {
                                        Console.WriteLine("symbol " + guess[i] + " is correct");
                                    }
                                }

                                Console.WriteLine("You lose :(");
                            }
                            attempts--;
                            Console.WriteLine("you have " + (attempts - 6) + " attempts left");
                        }
                }
            }
        }
    }
}
