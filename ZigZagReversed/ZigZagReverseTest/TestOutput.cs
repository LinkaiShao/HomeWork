//-----------------------------------------------------------------------
// <copyright file="TestOutput.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ZigZagReverseTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZigZagReversed;

    /// <summary>
    /// The output used for testing 
    /// </summary>
    public class TestOutput : IOutput
    {
        /// <summary>
        /// For creating new list
        /// </summary>
        private bool createNewList = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestOutput"/> class.
        /// </summary>
        public TestOutput()
        {
            this.Data = new List<List<int>>();
        }

        /// <summary>
        /// Gets data  
        /// </summary>
        public List<List<int>> Data { get; }

        /// <summary>
        /// Every time when new line, create new list 
        /// </summary>
        public void NewLine()
        {
            this.createNewList = true;
        }

        /// <summary>
        /// Adds the content to data
        /// </summary>
        /// <param name="content"> an integer that is turned into string </param>
        public void Write(string content)
        {
            if (this.createNewList)
            {
                this.Data.Add(new List<int>());
                this.createNewList = false;
            }

            this.Data[this.Data.Count - 1].Add(int.Parse(content.Trim()));
        }
    }
}
