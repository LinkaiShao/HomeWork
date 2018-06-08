//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Linkai">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Months_Ting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This ting takes in months and returns days
        /// </summary>
        /// <param name="month"> Insert the month you want to find the days of </param>
        /// <returns> Returns the days </returns>
        public static int MonthDays(int month)
        {
            int[] months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return months[month - 1];
        }

        /// <summary>
        /// This big ting is the same as month days 1 except for used 2 ifs and no arrays.
        /// </summary>
        /// <param name="month"> The month </param>
        /// <returns> The days </returns>
        public static int MonthDays2(int month)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 28;
            }   
        }

        /// <summary>
        /// Main thing
        /// </summary>
        /// <param name="args"> It comes with it </param>
        private static void Main(string[] args)
        {
            int days = MonthDays2(1);
            Console.WriteLine("The day is {0}", days);
            Console.ReadLine();
        }
    }
}
