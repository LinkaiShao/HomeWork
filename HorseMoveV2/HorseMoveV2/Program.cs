using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseMoveV2
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var x = CheckHouseMove(null, null, null);
        }

        private static readonly int[,] positionsToCheck = new int[,]
        {
            { 2, 1 },
            { 1, 2 },
            { -1, 2 },
            { -2, 1 },
            { 2, -1 },
            { 1, -2 },
            { -1, -2 },
            { -2, -1 },
        };

        public static bool CheckHouseMove(int[][] board, Position current, Position destination)
        {
            // Check: if out-of borad, return false;
            // check: if destination piece is 0 or 1, return false;

            var length = positionsToCheck.GetLength(0);
            for (var i = 0; i < length ; i++)
            {
                if ((destination.X + positionsToCheck[i, 0] == destination.X)
                    && (destination.Y + positionsToCheck[i, 1] == destination.Y))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
