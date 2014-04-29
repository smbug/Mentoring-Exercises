using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzGeneratorSpecification
    {
        [Test]
        public void FizzBuzz_Returns_UpperLimit_Items()
        {
            var fizzbuzz = new FizzBuzzGenerator();

            Assert.That(fizzbuzz.FizzBuzz(10).Count(), Is.EqualTo(10), "Expected FizzBuzz( 10 ) to return 10 items"); 
        }

        [Test]
        public void FizzBuzz_Negative_Returns_Empty_Enumeration()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.IsEmpty(fizzBuzz.FizzBuzz(-5), "Expected FizzBuzz( -5 ) to return no items");
        }

        [Test]
        public void FizzBuzz_Zero_Returns_Empty_Enumeration()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.IsEmpty(fizzBuzz.FizzBuzz(0), "Expected FizzBuzz( 0 ) to return no items");
        }

        [Test]
        public void FizzBuzz_Factor_Returns_Fizz()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.That(fizzBuzz.FizzBuzz(3).ElementAt(2), Is.EqualTo("Fizz"), "Expected 3rd element in FizzBuzz( 3 ) to be \"Fizz\"");
        }

        [Test]
        public void FizzBuzz_Multiple_Returns_Fizz()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.That(fizzBuzz.FizzBuzz(36).ElementAt(35), Is.EqualTo("Fizz"), "Expected 36th element in FizzBuzz( 36 ) to be \"Fizz\"");
        }

        [Test]
        public void FizzBuzz_Factor_Returns_Buzz()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.That(fizzBuzz.FizzBuzz(5).ElementAt(4), Is.EqualTo("Buzz"), "Expected 5th element in FizzBuzz( 5 ) to be \"Buzz\"");
        }

        [Test]
        public void FizzBuzz_Multiple_Results_Buzz()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.That(fizzBuzz.FizzBuzz(40).ElementAt(39), Is.EqualTo("Buzz"), "Expected 40th element in FizzBuzz( 40 ) to be \"Buzz\"");
        }

        [Test]
        public void FizzBuzz_Factors_Returns_FizzBuzz()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.That(fizzBuzz.FizzBuzz(15).ElementAt(14), Is.EqualTo("FizzBuzz"), "Expected 15th element in FizzBuzz( 15 ) to be \"FizzBuzz\"");
        }

        [Test]
        public void FizzBuzz_Multiple_Returns_FizzBuzz()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.That(fizzBuzz.FizzBuzz(135).ElementAt(134), Is.EqualTo("FizzBuzz"), "Expected 135th element in FizzBuzz( 135 ) to be \"FizzBuzz\"");
        }

        [Test]
        public void FizzBuzz_Fifteen_Returns_Correct_Sequence()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            var correctSequence = new List<string> { "1", "2", "Fizz", "4" ,"Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            Assert.That(fizzBuzz.FizzBuzz(15), Is.EqualTo(correctSequence), "Expected FizzBuzz ( 15 ) to be"
                + " {\"1\", \"2\", \"Fizz\", \"4\" ,\"Buzz\", \"Fizz\", \"7\", \"8\", \"Fizz\", \"Buzz\", \"11\", \"Fizz\", \"13\", \"14\", \"FizzBuzz\"}");
        }
    }
}