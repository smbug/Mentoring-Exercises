Mentoring
=========
A set of coding exercises being used as part of mentoring a developer.
 
Exercise 1 - FizzBuzz
=================
Write a method that, given a number, returns the following for each integer between 1 and the number given:
 - "Fizz" if the number is divisible by 3
 - "Buzz" if the number is divisible by 5
 - "FizzBuzz" if the number is divisible by 3 and 5
 - otherwise return the number (as a string)
 - method should return an empty enumeration for numbers less than 1 
 
Exercise 1 is designed to be used in VS2010 Express Web Developer Edition.  
 - To run the tests:
   - open nunit.exe (tools\nunit-2.6.3\bin\nunit.exe) 
   - load the .nunit file in the exercise folder
   - ensure nunit is set up to reload everything on each test run
   - build the solution in visual studio and hit the run button in nunit


Goals
---------
As much as possible, try to drive out the solution through your unit tests.

1.  Write a test
2.  Run the test and watch it fail (RED)
3.  Do the simplest possible thing to make it pass (GREEN)
4.  Clean up the code (both implementation and tests) as required (REFACTOR)

Commit the changes for each step so they can be discussed.


Exercise 2 - Broken Binary Search
=========================
1. Fix the broken binary search and clean up the code
2. Extend the implementation so it handles / detects an attempt to search an unsorted array

Exercise 2 is designed to be used in VS2013 Express Web Developer Edition. Unit tests are written in MSTest, so you can use the built in test runner to run the tests.

Goals
--------
Simple concept but hard to get correct - binary searches are known for tripping up even the most experienced coders. While tests will allow you to confirm it works or doesn't,
you will have to think carefully about the implementation of the algorithm - TDD and unit tests do not have all the answers to your design problems.