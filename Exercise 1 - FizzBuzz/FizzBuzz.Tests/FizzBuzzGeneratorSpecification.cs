﻿using System;
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

            Assert.That(fizzBuzz.FizzBuzz(-5), Is.Empty, "Expected FizzBuzz( -5 ) to return no items");
        }

        [Test]
        public void FizzBuzz_Zero_Returns_Empty_Enumeration()
        {
            var fizzBuzz = new FizzBuzzGenerator();

            Assert.That(fizzBuzz.FizzBuzz(0), Is.Empty, "Expected FizzBuzz( 0 ) to return no items");
        }
    }
}
