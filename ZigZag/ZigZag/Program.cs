//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ZigZag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main class
        /// </summary>
        /// <param name="args"> arguments of main </param>
        public static void Main(string[] args)
        {
            List<List<int>> newList = ZigZag(100, 10);
            Console.ReadLine();
        }

        /// <summary>
        /// The zigzag function that lays out the numbers in a zig zagged fashion
        /// </summary>
        /// <param name="maxnum"> the maximum number </param>
        /// <param name="limit"> numbers each line </param>
        /// <returns> for testing, a double list that contains the whole scene </returns>
        public static List<List<int>> ZigZag(int maxnum, int limit)
        {
            List<List<int>> wholeScene = new List<List<int>>();
            int current = 1;
            bool forward = true;
            if (limit == 0)
            {
                return wholeScene;
            }

            while (current - 1 != maxnum)
            {
                ////for testing purposes
                List<int> thisLine = new List<int>();
                ////for testing purposes
                Console.WriteLine();
                if (forward)
                {
                    // if the whole thing ends before end of the line
                    if ((current + limit) > maxnum)
                    {
                        for (int i = current; i < maxnum; i++)
                        {
                            thisLine.Add(i);
                            Console.Write(i);
                        }

                        current = maxnum;
                        break;
                    }

                    int current1 = current;
                    //// normal circumstances
                    for (int i = current1; i < current1 + limit; i++)
                    {
                        ////Make sure each line has the same spacing
                        for (int j = 0; j < maxnum.ToString().Length - current1.ToString().Length; j++)
                        {
                            Console.Write(" ");
                        }
                        
                        current = i;
                        thisLine.Add(current);
                        Console.Write(current + " ");
                    }
                    
                    forward = false;
                }
                else
                {
                    // When the end of the whole thing is in this lane
                    if ((current + limit) > maxnum)
                    {
                        for (int i = maxnum; i > current; i--)
                        {
                            thisLine.Add(i);
                            Console.Write(i + " ");
                        }

                        current = maxnum;
                        break;
                    }
                    //// normal circumstances
                    int current1 = current;
                    for (int i = current1 + limit; i > current1; i--)
                    {
                        // same spacing
                        for (int j = 0; j < maxnum.ToString().Length - current1.ToString().Length; j++)
                        {
                            Console.Write(" ");
                        }

                        current = i;
                        thisLine.Add(current);
                        Console.Write(current + " ");
                    }

                    current = current + limit;
                    forward = true;
                }

                wholeScene.Add(thisLine);
            }

            return wholeScene;
        }
    }
}
