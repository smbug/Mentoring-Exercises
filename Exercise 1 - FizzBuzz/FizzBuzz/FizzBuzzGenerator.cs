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
        /// Generates the following "FizzBuzz" strings for each integer between 1 and a given number:
        /// <list type="bullet">
        /// <item><description>"Fizz" if the integer is divisible by 3,</description></item> 
        /// <item><description>"Buzz" if the integer is divisible by 5,</description></item> 
        /// <item><description>"FizzBuzz" if the integer is divisible by 3 and 5, or</description></item> 
        /// <item><description>the integer itself</description></item>
        /// </list> 
        /// </summary>
        /// <param name="upperLimit">Upper limit of integer sequence used to generate the "FizzBuzz" strings</param>
        /// <returns>An empty enumeration, if <paramref name="upperLimit"/> is less than 1. 
        /// Otherwise, an enumerable of "FizzBuzz" strings.</returns>
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

            if (value % fizzFactor == 0 && value % buzzFactor == 0)
            {
                return "FizzBuzz";
            }
            else if (value % fizzFactor == 0)
            {
                return "Fizz";
            }
            else if (value % buzzFactor == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }
    }
}