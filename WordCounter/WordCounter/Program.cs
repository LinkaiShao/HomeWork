//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace WordCounter
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
        /// Main class
        /// </summary>
        /// <param name="args"> arguments of main </param>
        public static void Main(string[] args)
        {
            Dictionary<string, int> dict = CountWords("hi i am j j");
        }

        /// <summary>
        /// The word counter takes in input and tells you amount of words it has
        /// </summary>
        /// <param name="input"> sentence </param>
        /// <returns> the amount of words the input has </returns>
        public static int WordCounter(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]) == true)
                {
                    count++;
                }
            }

            if (input.Length > 2)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Put in input to get a dictionary of words of the input
        /// </summary>
        /// <param name="input"> a string </param>
        /// <returns> a dictionary with the word and amount of time it appears </returns>
        public static Dictionary<string, int> CountWords(string input)
        {
            Dictionary<string, int> record = new Dictionary<string, int>();
            int previous = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    if (!record.ContainsKey(input.Substring(previous + 1, i - previous - 1)))
                    {
                        record.Add(input.Substring(previous + 1, i - previous - 1), 1);
                    }
                    else
                    {
                        record[input.Substring(previous + 1, i - previous - 1)] += 1;
                    }

                    previous = i;
                }
            }

            if (!record.ContainsKey(input.Substring(previous + 1, input.Length - previous - 1)))
            {
                record.Add(input.Substring(previous + 1, input.Length - previous - 1), 1);
            }
            else
            {
                record[input.Substring(previous + 1, input.Length - previous - 1)] += 1;
            }

            return record;
        }
    }
}
