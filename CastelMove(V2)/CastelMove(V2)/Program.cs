using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastelMove_V2_
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    public class Program
    {
        static void Main(string[] args)
        {
        }

        public bool CheckPosition(int[][] board, Position current, Position destination)
        {
            int deltaX = Math.Sign(destination.X - current.X);
            int deltaY = Math.Sign(destination.Y - current.Y);

            if ((deltaX != 0) && (deltaY != 0))
            {
                return false;
            }

            int x = current.X;
            int y = current.Y;
            while ((x != destination.X) && (y != destination.Y))
            {
                if (board[x][y] != 0)
                {
                    return false;
                }

                x += deltaX;
                y += deltaY;
            }

            return true;
        }
        public static bool HorseMove (int[][] board, Position current, Position destination)
        {
            if (board[destination.X][destination.Y] == 1)
            {
                return false;
            }

            int deltaX = Math.Sign(destination.X - current.X);
            int deltaY = Math.Sign(destination.Y - current.Y);
            if (current.X + 2 * deltaX == destination.X && current.Y + deltaY == destination.Y)
            {
                if(board[current.X+deltaX][current.Y]==1|| board[current.X + deltaX][current.Y] == 2)
                {
                    return false;
                }
                return true;
            }
            else if(current.X + deltaX == destination.X && current.Y + 2*deltaY == destination.Y)
            {
                if(board[current.X][current.Y+deltaY]==1|| board[current.X][current.Y + deltaY] == 2)
                {
                    return false;
                }
                return true;
            }
            return false;

            
        }
    }
}
