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
    using System.Threading.Tasks;
    using System.Threading;

    /// <summary>
    /// Tests shit for me, runs number game
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main ting
        /// </summary>
        /// <param name="args"> those are args </param>
        public static void Main(string[] args)
        {
            NumberGame();
        }
        
        /// <summary>
        /// Runs the number game that has two kids guessing numbers 
        /// </summary>
        public static void NumberGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 99);
            int guess1 = 0;
            int guess2 = 0;
            int player1Guess = 0;
            int player2Guess = 0;
            while (true)
            {
                Console.WriteLine("player one turn");
                player1Guess += 1;
                guess1 = Convert.ToInt32(Console.ReadLine());
                if (guess1 == num)
                {
                    Console.WriteLine("player1 has won");
                    Console.WriteLine("he took {0} guesses", player1Guess);
                    Thread.Sleep(6000);
                    return;
                }
                else
                {
                    if (guess1 > num)
                    {
                        Console.WriteLine("smaller");
                    }
                    else
                    {
                        Console.WriteLine("Larger");
                    }

                    player2Guess += 1;
                    Console.WriteLine("player two turn");
                    guess2 = Convert.ToInt32(Console.ReadLine());
                    if (guess2 == num)
                    {
                        Console.WriteLine("player2 has won");
                        Console.WriteLine("he took {0} guesses", player2Guess);
                        Thread.Sleep(6000);
                        return;                   
                    }

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
        }
    }
}
