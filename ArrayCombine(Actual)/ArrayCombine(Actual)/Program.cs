//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ArrayCombine
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
        /// Main class
        /// </summary>
        /// <param name="args"> arguments of main </param>
        public static void Main(string[] args)
        {
        }

        /// <summary>
        /// The function that combines two arrays and return the combined array
        /// </summary>
        /// <param name="array1"> first array </param>
        /// <param name="array2"> second array </param>
        /// <returns> the combined array of the two and also sorted from smallest to largest </returns>
        public static int[] CombineArray(int[] array1, int[] array2)
        {
            List<int> combined = new List<int>(array1.ToList<int>());
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < combined.Count; j++)
                {
                    if (array2[i] < combined[j] || array2[i] == combined[j])
                    {
                        combined.Insert(j, array2[i]);
                        break;
                    }
                }
            }

            return combined.ToArray();
        }
    }
}
