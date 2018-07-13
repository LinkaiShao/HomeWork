//-----------------------------------------------------------------------
// <copyright file="IOutput.cs" company="CompanyName">
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
    /// The interface that contains classes that can show content on console and also testing 
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// When the program writes something
        /// </summary>
        /// <param name="content"> a number that was converted to string </param>
        void Write(string content);

        /// <summary>
        /// When a new line is created, not used for testing 
        /// </summary>
        void NewLine();
    }
}
