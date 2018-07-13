//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ZigZagReversed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Program class 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main class
        /// </summary>
        /// <param name="args"> arguments of main </param>
        public static void Main(string[] args)
        {
            IOutput output = new Output();
            ZigZagReverse(20, 5, output);
            Console.ReadLine();
        }

        /// <summary>
        /// Reverses the set of numbers in an up-down fashion
        /// </summary>
        /// <param name="maxnum"> the largest number </param>
        /// <param name="limit"> number of numbers every column </param>
        /// <param name="output"> the output for testing </param>
        public static void ZigZagReverse(int maxnum, int limit, IOutput output)
        {
            if (limit == 0)
            {
                return;
            }
               
            int evenConst = -1;
            int oddConst = 1;
            int previous = 1;
            int next = 0;
            bool oddlayer = true;
            for (int i = 0; i < limit; i++)
            {
                output.NewLine();
                while (!(next > maxnum))
                {
                    if (previous < limit || !oddlayer)
                    {
                        next = previous + (2 * limit) + evenConst;
                        oddlayer = true;
                    }
                    else if (oddlayer)
                    {
                        next = previous + oddConst;
                        oddlayer = false;
                    }

                    output.Write(previous.ToString());
                    previous = next;
                }

                evenConst -= 2;
                oddConst += 2;
                next = i + 2;
                previous = next;
            }
        }
    }
}
