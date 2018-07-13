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

        /// <summary>
        /// The function that combines two arrays and return the combined array
        /// </summary>
        /// <param name="array1"> first array </param>
        /// <param name="array2"> second array </param>
        /// <returns> the combined array of the two and also sorted from smallest to largest </returns>
        public static int[] CombineArray2(int[] array1, int[] array2)
        {
            List<int> combined = array1.ToList<int>();
            combined.AddRange(array2.ToList<int>());
            combined.Sort();
            return combined.ToArray();
        }

        /// <summary>
        /// The function that combines two arrays and return the combined array
        /// </summary>
        /// <param name="array1"> first array </param>
        /// <param name="array2"> second array </param>
        /// <returns> the combined array of the two and also sorted from smallest to largest </returns>
        public static int[] CombineArray3(int[] array1, int[] array2)
        {
            List<int> list1 = array1.ToList<int>();
            List<int> list2 = array2.ToList<int>();
            List<int> combined = new List<int>();
            int current = 0;
            while (!(list1.Count == 0 && list2.Count == 0))
            {
                if (list1.Count == 0)
                {
                    combined.AddRange(list2);
                    break;
                }
                else if (list2.Count == 0)
                {
                    combined.AddRange(list1);
                    break;
                }

                if (list1[0] < list2[0] || list1[0] == list2[0])
                {
                    current = list1[0];
                }
                else
                {
                    current = list2[0];
                }

                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[0] == current)
                    {
                        combined.Add(list1[0]);
                        list1.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 0; i < list2.Count; i++)
                {
                    if (list2[0] == current)
                    {
                        combined.Add(list2[0]);
                        list2.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return combined.ToArray();
        }
    }
}
