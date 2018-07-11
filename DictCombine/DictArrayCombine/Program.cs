//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DictArrayCombine
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
        /// <param name="args"> the arguments of main </param>
        public static void Main(string[] args)
        {
        }

        /// <summary>
        /// This function combines two dictionaries into one
        /// </summary>
        /// <param name="input1"> the first dictionary </param>
        /// <param name="input2"> second dictionary</param>
        /// <returns> the dictionary that was the combination of the two </returns>
        public static Dictionary<string, string> CombineDict(Dictionary<string, string> input1, Dictionary<string, string> input2)
        {
            Dictionary<string, string> output = new Dictionary<string, string>(input1);
            foreach (var item in input2)
            {
                if (!output.ContainsKey(item.Key))
                {
                    output.Add(item.Key, item.Value);
                }
            }

            return output; 
        }
    }
}
