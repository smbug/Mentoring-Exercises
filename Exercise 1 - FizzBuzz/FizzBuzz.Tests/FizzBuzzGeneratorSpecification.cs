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
            var expectedResult = new List<string>{ "1", "2", "Fizz" };
            Assert.That(fizzBuzz.FizzBuzz(3), Is.EqualTo(expectedResult), "Expected FizzBuzz( 3 ) to return { 1, 2, Fizz }");
        }
    }
}
