//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Linkai">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace EnglishToSamuel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Program runs dictionary and tests itself
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Dictionary that contains characters to morse code. 
        /// </summary>
        private static Dictionary<char, string> convertDict;

        /// <summary>
        /// Creates the dictionary and runs the function
        /// </summary>
        /// <param name="args"> Main thing of the code </param>
        public static void Main(string[] args)
        {
            convertDict = new Dictionary<char, string>()
            {
                { 'a', ".-" },
                { 'b', "-..." },
                { 'c', "-.-." },
                { 'd', "-.." },
                { 'e', "." },
                { 'f', "..-." },
                { 'g', "--." },
                { 'h', "...." },
                { 'i', ".." },
                { 'j', ".---" },
                { 'k', "-.-" },
                { 'l', ".-.." },
                { 'm', "--" },
                { 'n', "-." },
                { 'o', "---" },
                { 'p', ".--." },
                { 'q', "--.-" },
                { 'r', ".-." },
                { 's', "..." },
                { 't', "-" },
                { 'u', "..-" },
                { 'v', "...-" },
                { 'w', ".--" },
                { 'x', "-..-" },
                { 'y', "-.--" },
                { 'z', "--.." }
            };
            Console.WriteLine("what do you want to transfer");
            string userInput = Console.ReadLine();
            Console.WriteLine(Convert(userInput));
            Console.ReadLine();
        }

        /// <summary>
        /// Converts the English to Morse code
        /// </summary>
        /// <param name="input"> Put in the input </param>
        /// <returns> a string of Morse Shit </returns>
        public static string Convert(string input)
        {
            string output = string.Empty;
            foreach (char letters in input)
            {
                if (convertDict.ContainsKey(letters))
                {
                    output += convertDict[letters];
                }
                else
                {
                    output += "_ ";
                }
            }

            return output;
        }
    }
}
