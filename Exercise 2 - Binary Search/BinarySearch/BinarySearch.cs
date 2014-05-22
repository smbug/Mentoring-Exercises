using System;
using System.Linq;

namespace BinarySearch
{
    /// <summary>
    /// Simple binary search.
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// Searches an array of integers for a specific number.
        /// </summary>
        /// <param name="data">Array to search through</param>
        /// <param name="target">Number to find</param>
        /// <returns>If the number exists in the array, the index of the target number. Otherwise, null.</returns>
        /// <exception cref="ArgumentNullException">Occurs when <paramref name="data"/> is null.</exception>
        public int? Find(int[] data, int target)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }
            
            if (data.Length == 0)
            {
                return null;
            }

            Array.Sort(data);

            var min = 0;
            var max = data.Length - 1;

            while (min <= max)
            {
                var midpoint = (min + max) / 2;
                var midpointValue = data[midpoint];

                if (midpointValue == target)
                {
                    return midpoint;
                }
                else if (midpointValue < target) 
                {
                    min = midpoint + 1;
                }
                else
                {
                    max = midpoint - 1;
                }
            }

            return null;
        }
    }
}