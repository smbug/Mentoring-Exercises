using System;
using System.Linq;

namespace BinarySearch
{
    /// <summary>
    /// Simple binary search.
    /// 
    /// NOTE
    /// There is no "best" way to handle duplicate values; it all depends on what the search is required for.
    /// Below are a few ways to handle duplicate values:
    /// 
    /// 1. Check that the array has distinct values, and throw an exception if it does not.
    /// PROS: Useful for finding a value in a collection of keys.
    /// CONS: Seems drastic to throw an exception when changing the collection type to a HashSet
    /// will enforce the uniqueness constraint.
    /// 
    /// 2. Change the method signature to accept a HashSet. 
    /// PROS: Useful for finding a value in a collection of keys. Also, since a HashSet will always have 
    /// unique values, it will never need to be checked for duplicate values before the search begins.
    /// CONS: Constrained to collection of distinct values.
    /// 
    /// 3. Change the method signature to return a boolean, and use the basic binary search algorithm.
    /// PROS: Useful for confirming the existence of a value in a collection, much like a "Contains" method.
    /// CONS: Will not return the position of a target.
    /// 
    /// 4. Allow arrays with duplicate values, use the basic binary search algorithm, and explain in the
    /// method comment that the index of any instance of the target will be returned.
    /// PROS: Useful for situations where the position of a target is not important.
    /// CONS: Its 'pro' is also its downfall; method is not useful for finding specific positions.
    /// 
    /// 5. Modify the binary search algorithm to return the first index of the target, if it exists. For 
    /// example, given {0, 2, 2, 2, 2, 3}, the algorithm will return 1, when searching for 2.
    /// PROS: Useful for situations where the first position of a target is important.
    /// CONS: Best case will be O(log(n)), unlike the basic binary search algorithm, as the entire array will 
    /// need to be searched before stopping.
    /// 
    /// 6. Modify the binary search algorithm to return the first and last index of the target, if it exists.
    /// For example, given {0, 2, 2, 2, 2, 3}, the algorithm will return 1 and 4, when searching for 2.
    /// PROS: Useful for situations where the spread of a target needs to be found.
    /// CONS: Best case will be O(log(n)), unlike the basic binary search, as the entire array will need to be
    /// searched before stopping.
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
        /// <exception cref="ArgumentException">Occurs when <paramref name="data"/> is not sorted in 
        /// ascending order</exception>
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