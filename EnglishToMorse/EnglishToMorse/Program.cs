//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Linkai">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace EnglishToMorse
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
        /// <param name="args"> The arguments for main </param>
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
                { 'z', "--.." },
                { '1', ".----" },
                { '2', "..---" },
                { '3', "...--" },
                { '4', "....-" },
                { '5', "....." },
                { '6', "-...." },
                { '7', "--..." },
                { '8', "---.." },
                { '9', "----." },
                { '0', "-----" }
            };
            Console.WriteLine("what do you want to transfer");
            string userInput = Console.ReadLine();
            if (userInput != null || userInput.Length > 0)
            {
                Console.WriteLine(Convert(userInput));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Can't have null for your input");
            }
        }

        /// <summary>
        /// Converts the English to Morse code
        /// </summary>
        /// <param name="input"> Put in the input like numbers, letters </param>
        /// <returns> a string of Morse </returns>
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
                    output += "/";
                }
            }

            return output;
        }
    }
}
