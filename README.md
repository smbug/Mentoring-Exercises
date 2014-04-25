Mentoring
=========
A set of coding exercises being used as part of mentoring a developer.
 - The exercises are designed to be used in VS2010 Express Web Developer Edition.  
 - To run the tests:
   - open nunit.exe (tools\nunit-2.6.3\bin\nunit.exe) 
   - load the .nunit file in the exercise folder
   - ensure nunit is set up to reload everything on each test run
   - build the solution in visual studio and hit the run button in nunit

Exercise 1 - FizzBuzz
=================
Write a method that, given a number, returns the following for each integer between 1 and the number given:
 - "Fizz" if the number is divisible by 3
 - "Buzz" if the number is divisible by 5
 - "FizzBuzz" if the number is divisible by 3 and 5

Method should return an empty enumeration for numbers less than 1 

Goals
---------
As much as possible, try to drive out the solution through your unit tests.

1.  Write a test
2.  Run the test and watch it fail (RED)
3.  Do the simplest possible thing to make it pass (GREEN)
4.  Clean up the code (both implementation and tests) as required (REFACTOR)

Commit the changes for each step so they can be discussed.
