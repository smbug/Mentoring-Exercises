using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// Simple "FizzBuzz" generator.
    /// </summary>
    public class FizzBuzzGenerator
    {
        /// <summary>
        /// Generates one of the following "FizzBuzz" strings for each integer between 1 and a given number:
        /// <list type="bullet">
        /// <item><description>"Fizz" if the integer is divisible by 3</description></item> 
        /// <item><description>"Buzz" if the integer is divisible by 5</description></item> 
        /// <item><description>"FizzBuzz" if the integer is divisible by 3 and 5</description></item> 
        /// <item><description>Otherwise, the integer itself</description></item>
        /// </list> 
        /// </summary>
        /// <param name="upperLimit">Upper limit of the integer sequence used to generate the "FizzBuzz" strings</param>
        /// <returns>An empty IEnumerable collection, if <paramref name="upperLimit"/> is less than 1. 
        /// Otherwise, an IEnumerable collection of "FizzBuzz" strings.</returns>
        public IEnumerable<string> FizzBuzz(int upperLimit)
        {
            if (upperLimit <= 0)
            {
                return Enumerable.Empty<string>();
            }

            var results = new List<string>();

            for (int i = 1; i <= upperLimit; i++)
            {
                results.Add(GenerateFizzBuzz(i));
            }

            return results;
        }

        private static string GenerateFizzBuzz(int value)
        {
            var fizzFactor = 3;
            var buzzFactor = 5;

            var result = string.Empty;

            if (value % fizzFactor == 0)
            {
                result = "Fizz";
            }

            if (value % buzzFactor == 0)
            {
                result += "Buzz";
            }

            return string.IsNullOrEmpty(result) ? value.ToString() : result;
        }
    }
}