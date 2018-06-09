//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BinaryThing
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
        /// The main function
        /// </summary>
        /// <param name="args"> arguments of main </param>
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12 };
            Console.WriteLine(BinarySearch(numbers, 2));
            Console.ReadLine();
        }

        /// <summary>
        /// The binary search method that limits the range to find numbers more efficiently
        /// </summary>
        /// <param name="array"> the input array </param>
        /// <param name="number"> input number </param>
        /// <returns> the position of the number, -1 if not found </returns>
        public static int BinarySearch(int[] array, int number)
        {
            int first = 0;
            int last = array.Length - 1;
            int mid = 0;
            if (array[first] > number || array[last] < number)
            {
                return -1;
            }

            // loop until head meets toe
            while (first <= last)
            {
                // Since its an integer, the decimals would be converted to whole number
                mid = (first + last) / 2;

                // if number is bigger than mid, limit by half by moving first to mid + 1. This way, the array having even number of items is resolved and would be more efficient since it has less numbers to care about
                if (number > array[mid])
                {
                    first = mid + 1;
                }
                else if (number < array[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
