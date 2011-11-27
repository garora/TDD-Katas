# TDD-Katas : Continus TDD-Kata practices

## String Calculator

	- Create a simple String calculator with a method int Add(string numbers)
		- The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will
  		  return 0) for example “” or “1” or “1,2”
		- Start with the simplest test case of an empty string and move to 1 and two numbers
		- Remember to solve things as simply as possible so that you force yourself to write tests you did
		  not think about
		- Remember to refactor after each passing test
	- Allow the Add method to handle an unknown amount of numbers
	- Allow the Add method to handle new lines between numbers (instead of commas).
		- the following input is ok:  “1\n2,3”  (will equal 6)
		- the following input is NOT ok:  “1,\n” (not need to prove it - just clarifying)
	- Support different delimiters
			to change a delimiter, the beginning of the string will contain a separate line that looks like this:   
			“//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ .
			the first line is optional. all existing scenarios should still be supported
	- Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed.
	  if there are multiple negatives, show all of them in the exception message 
	
----------------------------------------------------------------
	Completed first Kata example	
----------------------------------------------------------------

## The Bowling Game Kata
	- Following Uncle bob post from here : http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata
	- Create a new project or start in the existing project by adding Game.cs and TestGame.cs
	- Create two public methods methods [refer to the presentation file]
	- Create Test Methods for the above Methods
	- This is called a 'RED' Test as it is going to fail.
	- Rectified both test and class methods
	- Write new test
	- This is called a 'Green' Test as it is going to pass.
	- Rectified TestMethods to meet total 20 frames hit.
	- Rectified test to accept multiple frame and pins
	- Test 3 is a 'Red' test
	- Test 4 and 5 are 'Green'
	- All test passed
	- Still there is scope of refactoring

## The FizzBuzz Kata
	- Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" 
	  instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both 
	  three and five print "FizzBuzz".
	  
### Steps:

	Lets divide this into different steps so, we can easily write and test this.
	- Print numbers from 1 to 100
	- Print "Fizz" instead of number which is divisible by 3
	- Print "Buzz" instead of number which is divisible by 5
	- Print "FizzBuzz" instead of number which is divisible by both 3 and 5

#### Make more test for accept numbers and provide results
	- Create a method to accept single number
	- Create test to verify supplied number within the range 1 to 100
	- Create test to verify number and return result Fizz or Buzz or FizzBuzz per above criteria

## The OddEven Kata
	- Write a program that prints numbers within specified range lets say 1 to 100. If number is odd print 'Odd'
	  instead of the number. If number is even print 'Even' instead of number. Else print number [hint - if number is Prime].

### Steps :

	Lets divide into following stesp:
	- Prints numbers from 1 to 100
	- Print "Even" instead of number, if the number is even, means divisible by 2
	- Print "Odd" instead of number, if the number is odd, means not divisible by 2 but not divisible by itself too
	- Print number, if it does not meet above two conditions, means if number is Prime