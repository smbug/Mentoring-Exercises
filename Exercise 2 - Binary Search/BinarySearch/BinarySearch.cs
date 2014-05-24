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
        /// Searches an array of integers, sorted in ascending order, for a specific number.
        /// </summary>
        /// <param name="data">Array sorted in ascending order</param>
        /// <param name="target">Number to find</param>
        /// <returns>If the number exists in the array, the index of the target number. Otherwise, null.</returns>
        /// <exception cref="ArgumentNullException">Occurs when <paramref name="data"/> is null.</exception>
        /// <exception cref="ArgumentException">Occurs when <paramref name="data"/> is not sorted in ascending order</exception>
        public int? Find(int[] data, int target)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            if (!CheckArrayIsSorted(data))
            {
                // NOTE The array isn't being returned at the end of the method, so the calling method
                // may expect it to be in the same order as it was when it entered the method.
                // So, it seems better to throw an exception for an unsorted array, rather than to sort it,
                // to avoid unexpected surprises for the calling method.
                throw new ArgumentException("Array must be sorted in ascending order", "data");
            }
            
            if (data.Length == 0)
            {
                return null;
            }

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

        private static bool CheckArrayIsSorted(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i - 1] > data[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}