//-----------------------------------------------------------------------
// <copyright file="Output.cs" company="CompanyName">
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
    /// The output that shows on console
    /// </summary>
    public class Output : IOutput
    {
        /// <summary>
        /// When new line, writes line on console 
        /// </summary>
        public void NewLine()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Writes the content on console
        /// </summary>
        /// <param name="content"> integer that is given </param>
        public void Write(string content)
        {
            Console.Write(" " + content);
        }
    }
}
