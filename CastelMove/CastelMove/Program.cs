//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CastelMove
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The position on a board
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Gets or sets the X of the position Sets the X of position
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y of the position Sets the Y of position
        /// </summary>
        public int Y { get; set; }
    }

    /// <summary>
    /// The main program class that contains functions
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main of the program class
        /// </summary>
        /// <param name="args"> arguments of main </param>
        public static void Main(string[] args)
        {
        }

        /// <summary>
        /// Function that verifies if the castel could move to another position in one turn 
        /// </summary>
        /// <param name="board"> The board </param>
        /// <param name="current"> current place of the castel </param>
        /// <param name="destination"> The desired location </param>
        /// <returns> If could move or not </returns>
        public static bool VerifyCastelMovement(int[][] board, Position current, Position destination)
        {
            if (current.X > board.Length || current.Y > board[0].Length || destination.X > board.Length || destination.Y > board[0].Length)
            {
                return false;
            }

            if (current.X == destination.X && current.Y == destination.Y)
            {
                Console.WriteLine("You can't not move");
                return false;
            }

            if (board[destination.X][destination.Y] == 0 || board[destination.X][destination.Y] == 2)
            {
                if (current.X == destination.X)
                {
                    if (current.Y > destination.Y)
                    { 
                        for (int i = destination.Y + 1; i < current.Y; i++)
                        {
                            if (board[current.X][i] == 1 || board[current.X][i] == 2)
                            {
                                return false;
                            }
                        }
                    }
                    else if (current.Y < destination.Y)
                    {
                        for (int i = current.Y + 1; i < destination.Y; i++)
                        {
                            if (board[current.X][i] == 1 || board[current.X][i] == 2)
                            {
                                return false;
                            }
                        }
                    }

                    return true;
                }
                else if (current.Y == destination.Y)
                {
                    if (current.X > destination.X)
                    {
                        for (int i = destination.X + 1; i < current.X; i++)
                        {
                            if (board[i][current.Y] == 1 || board[i][current.Y] == 2)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        for (int i = current.X + 1; i < destination.X; i++)
                        {
                            if (board[i][current.Y] == 1 || board[i][current.Y] == 2)
                            {
                                return false;
                            }
                        }
                    }

                    return true;
                }    
            }

            return false;
        }
    }
}
