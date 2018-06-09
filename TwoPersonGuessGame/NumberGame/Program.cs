//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace NumberGameThing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main class
        /// </summary>
        /// <param name="args"> the arguments of main </param>
        public static void Main(string[] args)
        {
            NumberGame();
        }
        
        /// <summary>
        /// Runs the number game that has two kids guessing numbers. The kid who guesses the number first wins. (This game is only for kids)
        /// </summary>
        public static void NumberGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 99);
            int guess1 = 0;
            int guess2 = 0;
            bool player1Able = false;
            bool player2Able = false;
            int player1Guess = 0;
            int player2Guess = 0;
            while (true)
            {
                Console.WriteLine("player one turn");
                player1Guess += 1;
                while (!player1Able)
                {
                    if (int.TryParse(Console.ReadLine(), out guess1))
                    {
                        player1Able = true;
                    }
                }
                
                if (guess1 == num && player1Able)
                {
                    Console.WriteLine("player1 has won");
                    Console.WriteLine("he took {0} guesses", player1Guess);
                    Thread.Sleep(6000);
                    return;
                }
                else if (player1Able)
                {
                    if (guess1 > num)
                    {
                        Console.WriteLine("smaller");
                    }
                    else
                    {
                        Console.WriteLine("Larger");
                    }

                    Console.WriteLine("player two turn");
                    player2Guess += 1;
                    while (!player2Able)
                    {
                        if (int.TryParse(Console.ReadLine(), out guess2))
                        {
                            player2Able = true;
                        }
                    }

                    if (guess2 == num && player2Able)
                    {
                        Console.WriteLine("player2 has won");
                        Console.WriteLine("he took {0} guesses", player2Guess);
                        Thread.Sleep(6000);
                        return;                   
                    }
                    else if (player2Able)
                    {
                        if (guess2 > num)
                        {
                            Console.WriteLine("smaller");
                        }
                        else
                        {
                            Console.WriteLine("Larger");
                        }
                    }                  
                }

                player1Able = false;
                player2Able = false;
            }
        }
    }
}
