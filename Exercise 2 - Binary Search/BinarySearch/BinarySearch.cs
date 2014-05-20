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
        /// <returns>If the number exists in the array, the index of the target number.
        /// Otherwise, null.</returns>
        public int? Find(int[] data, int target)
        {
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
    }
}
