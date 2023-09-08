using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string colorCombination;

            Console.WriteLine("*****************");
            Console.WriteLine("Mastermind Game");
            Console.WriteLine("*****************");
            Console.WriteLine("");
            Console.WriteLine("Welcome, player.");
            Console.WriteLine("You need to find the color combination with the letters:");
            Console.WriteLine("R-G-B");
            colorCombination = Console.ReadLine();

            if (colorCombination == "GRB")
            {
                Console.WriteLine("You Win!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You lose");
                Console.ReadLine();
            }
            



        }
    }
}
