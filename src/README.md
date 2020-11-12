## Recently Used List

Develop a recently-used-list class to hold strings
uniquely in Last-In-First-Out order.

- The most recently added item is first, the least
  recently added item is last.

- Items can be looked up by index, which counts from zero.

- Items in the list are unique, so duplicate insertions
  are moved rather than added.

- A recently-used-list is initially empty.

Optional extras:

- Null insertions (empty strings) are not allowed.

- A bounded capacity can be specified, so there is an upper
  limit to the number of items contained, with the least
  recently added items dropped on overflow.
	   
See [a video tutorial showing how to solve this kata in Python](http://medrela.com/rul-kata).
	 
More tests:
	
- While getting items by index, supplied index-value should be within the bounds of List [eg.
  if maximum item counts of list is 5 then supplied index is less than 4 as index starts from 0 (zero)]
- Negative index value not allowed [>0]
- Size limit is must if not supplied make 5 as default [0-4]
- List can be non-sizable means without upper limit list can be created [Hint-try property or constructor initializers]

## String Sum Kata 

* Write a simple String Sum utility with a function <em>string Sum(string num1, string num2)</em>, which can accept only natural numbers and will return their sum. Replace entered number with <em>0 (zero)</em> if entered number is not a natural number.
* Stat with a simplest test case with an empty string
* Create a simple method <em>string Sum(string num1, string num2)</em>
* Write a test to pass small numbers and refactor, if test passed
* try to write more code and refactor


## String Calculator Kata (via [Roy Osherove](http://osherove.com/tdd-kata-1/))

* Create a simple String calculator with a method int Add(string numbers). The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0). For example "" or "1" or "1,2"
	* Start with the simplest test case of an empty string and move to 1 and two numbers
	* Remember to solve things as simply as possible so that you force yourself to write tests you did
		  not think about
	* Remember to refactor after each passing test
* Allow the Add method to handle an unknown amount of numbers
* Allow the Add method to handle new lines between numbers (instead of commas).
	* the following input is ok:  "1\n2,3"  (will equal 6)
	* the following input is NOT ok:  "1,\n" (not need to prove it - just clarifying)
* Support different delimiters. To change a delimiter, the beginning of the string will contain a separate line that looks like this: `[delimiter]\n[numbers...]`, for example `;\n1;2` should return three where the default delimiter is `;` .
	* he first line is optional. all existing scenarios should still be supported
* Calling Add with a negative number will throw an exception "negatives not allowed" - and the negative that was passed.
	* if there are multiple negatives, show all of them in the exception message


### The Bowling Game Kata ([via Uncle Bob](http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata))
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

### The FizzBuzz Kata
	- Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
	  instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both
	  three and five print "FizzBuzz".

### Including new implementation to The FizzBuzz Kata
	- Added a different implementation for FizzBuzz using Reactive extensions.
	- The changes are described at: http://blog.drorhelper.com/2015/02/fizzbuzz-tdd-kata-using-reactive.html
	- Pull Request by: https://github.com/dhelper (manually merged by @garora)
	  

#### Steps:

	Lets divide this into different steps so, we can easily write and test this.
	- Print numbers from 1 to 100
	- Print "Fizz" instead of number which is divisible by 3
	- Print "Buzz" instead of number which is divisible by 5
	- Print "FizzBuzz" instead of number which is divisible by both 3 and 5

#### Make more test for accept numbers and provide results
	- Create a method to accept single number
	- Create test to verify supplied number within the range 1 to 100
	- Create test to verify number and return result Fizz or Buzz or FizzBuzz per above criteria

### The OddEven Kata
	- Write a program that prints numbers within specified range lets say 1 to 100. If number is odd print 'Odd'
	  instead of the number. If number is even print 'Even' instead of number. Else print number [hint - if number is Prime].

#### Steps :

	Lets divide into following steps:
	- Prints numbers from 1 to 100
	- Print "Even" instead of number, if the number is even, means divisible by 2
	- Print "Odd" instead of number, if the number is odd, means not divisible by 2 but not divisible by itself too [hint - it should not be Prime]
	- Print number, if it does not meet above two conditions, means if number is Prime
	- Make method to accept any number of range [currently  we have 1 to 100]
	- Create a new method to check Odd/Even/Prime of a single supplied method

### The PrimeFactor Kata (via [Uncle Bob](http://butunclebob.com/ArticleS.UncleBob.ThePrimeFactorsKata))

### The PrimeComposite Kata
	- Write a program that prints numbers within specified range lets say 1 to 100. 
	- If number is ```prime``` print 'prime' instead of the number. 
	- If number is ```composite``` but not ```even``` print 'composite' instead of number.
	- Else print number. 
	- Reference(s)
		- [Prime numbers](https://en.wikipedia.org/wiki/Prime_number), 
		- [Composite numbers](https://en.wikipedia.org/wiki/Composite_number), 
		- [odd even](https://en.wikipedia.org/wiki/Parity_(mathematics))
  
### Steps   
	- Prints numbers from 1 to 100.
	- Print "Prime" instead of number, if the number is prime, means ```number greater than 1 that has no positive divisors other than 1 and itself```.
	- Print "Composite" instead of number, if the number is composite, means ```number has at least one positive divisor other than one or the number itself. In other words, a composite number is any integer greater than one that is not a prime number``` but not a ```even number```.
	- An even number is ```an integer is even if it is 'evenly divisible' by two```.
	- Print number, if it does not meet above two conditions.
	- Make method to accept any number of range [currently  we have 1 to 100].
	- Create a new method to check Prime/Composite of a single supplied method.

-------------------

### Kata - coming next [http://www.cyber-dojo.com/]

#### Calc Stats:

	Your task is to process a sequence of integer numbers
	to determine the following statistics:

		o) minimum value
		o) maximum value
		o) number of elements in the sequence
		o) average value

	For example: [6, 9, 15, -2, 92, 11]

		o) minimum value = -2
		o) maximum value = 92
		o) number of elements in the sequence = 6
		o) average value = 18.166666

#### Diversion :

	Think of binary numbers: sequences of 0's and 1's. How many
	n-digit binary numbers are there that don't have two adjacent
	1 bits?

	For example, for three-digit numbers, Five of the possible
	eight combinations meet the criteria:

	   000, 001, 010, 011, 100, 101, 110, 111.

	What is the number for sequences of length 4, 5, 10, n?

	Having worked out the pattern, there's a second part to the
	question: can you prove why that relationship exists?

#### Game of Life :

	Your task is to write a program to calculate the next
	generation of Conway's game of life, given any starting
	position. You start with a two dimensional grid of cells,
	where each cell is either alive or dead. The grid is finite,
	and no life can exist off the edges. When calculating the
	next generation of the grid, follow these four rules:

	1. Any live cell with fewer than two live neighbours dies,
	   as if caused by underpopulation.
	2. Any live cell with more than three live neighbours dies,
	   as if by overcrowding.
	3. Any live cell with two or three live neighbours lives
	   on to the next generation.
	4. Any dead cell with exactly three live neighbours becomes
	   a live cell.

	Examples: * indicates live cell, . indicates dead cell

	Example input: (4 x 8 grid)
	4 8
	........
	....*...
	...**...
	........

	Example output:
	4 8
	........
	...**...
	...**...
	........

#### Harry Potter :

	To try and encourage more sales of the 5 different Harry
	Potter books they sell, a bookshop has decided to offer
	discounts of multiple-book purchases.

	One copy of any of the five books costs 8 EUR.

	If, however, you buy two different books, you get a 5%
	discount on those two books.

	If you buy 3 different books, you get a 10% discount.

	If you buy 4 different books, you get a 20% discount.

	If you go the whole hog, and buy all 5, you get a huge 25%
	discount.

	Note that if you buy, say, four books, of which 3 are
	different titles, you get a 10% discount on the 3 that
	form part of a set, but the fourth book still costs 8 EUR.

	Your mission is to write a piece of code to calculate the
	price of any conceivable shopping basket (containing only
	Harry Potter books), giving as big a discount as possible.

	For example, how much does this basket of books cost?

	2 copies of the first book
	2 copies of the second book
	2 copies of the third book
	1 copy of the fourth book
	1 copy of the fifth book

	Answer: 51.60 EUR

#### LCD Digits :

	Your task is to create an LCD string representation of an
	integer value using a 3x3 grid of space, underscore, and
	pipe characters for each digit. Each digit is shown below
	(using a dot instead of a space)

	._.   ...   ._.   ._.   ...   ._.   ._.   ._.   ._.   ._.
	|.|   ..|   ._|   ._|   |_|   |_.   |_.   ..|   |_|   |_|
	|_|   ..|   |_.   ._|   ..|   ._|   |_|   ..|   |_|   ..|


	Example: 910

	._. ... ._.
	|_| ..| |.|
	..| ..| |_|

#### Leap Year :

	Write a function that returns true or false depending on
	whether its input integer is a leap year or not.

	A leap year is defined as one that is divisible by 4,
	but is not otherwise divisible by 100 unless it is
	also divisble by 400.

	For example, 2001 is a typical common year and 1996
	is a typical leap year, whereas 1900 is an atypical
	common year and 2000 is an atypical leap year.

#### Mine Fields :

	A field of N x M squares is represented by N lines of
	exactly M characters each. The character '*' represents
	a mine and the character '.' represents no-mine.

	Example input (a 4 x 3 mine-field of 12 squares, 2 of
	which are mines)

	4 3
	*...
	..*.
	....

	Your task is to write a program to accept this input and
	produce as output a hint-field of identical dimensions
	where each square is a * for a mine or the number of
	adjacent mine-squares if the square does not contain a mine.

	Example output (for the above input)
	*211
	12*1
	0111

#### Poker Hands

	A poker deck contains 52 cards - each card has a suit which
	is one of clubs, diamonds, hearts, or spades
	(denoted C, D, H, and S in the input data).

	Each card also has a value which is one of
	2, 3, 4, 5, 6, 7, 8, 9, 10, jack, queen, king, ace
	(denoted 2, 3, 4, 5, 6, 7, 8, 9, T, J, Q, K, A).

	For scoring purposes, the suits are unordered while the
	values are ordered as given above, with 2 being the lowest
	and ace the highest value.

	A poker hand consists of 5 cards dealt from the deck. Poker
	hands are ranked by the following partial order from lowest
	to highest.

	High Card: Hands which do not fit any higher category are
	ranked by the value of their highest card. If the highest
	cards have the same value, the hands are ranked by the next
	highest, and so on.

	Pair: 2 of the 5 cards in the hand have the same value.
	Hands which both contain a pair are ranked by the value of
	the cards forming the pair. If these values are the same,
	the hands are ranked by the values of the cards not
	forming the pair, in decreasing order.

	Two Pairs: The hand contains 2 different pairs. Hands
	which both contain 2 pairs are ranked by the value of
	their highest pair. Hands with the same highest pair
	are ranked by the value of their other pair. If these
	values are the same the hands are ranked by the value
	of the remaining card.

	Three of a Kind: Three of the cards in the hand have the
	same value. Hands which both contain three of a kind are
	ranked by the value of the 3 cards.

	Straight: Hand contains 5 cards with consecutive values.
	Hands which both contain a straight are ranked by their
	highest card.

	Flush: Hand contains 5 cards of the same suit. Hands which
	are both flushes are ranked using the rules for High Card.

	Full House: 3 cards of the same value, with the remaining 2
	cards forming a pair. Ranked by the value of the 3 cards.

	Four of a kind: 4 cards with the same value. Ranked by the
	value of the 4 cards.

	Straight flush: 5 cards of the same suit with consecutive
	values. Ranked by the highest card in the hand.

	Your job is to rank pairs of poker hands and to indicate
	which, if either, has a higher rank.

	Examples:
	Input: Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH
	Output: White wins - high card: Ace

	Input: Black: 2H 4S 4C 3D 4H White: 2S 8S AS QS 3S
	Output: White wins - flush

	Input: Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C KH
	Output: Black wins - high card: 9

	Input: Black: 2H 3D 5S 9C KD White: 2D 3H 5C 9S KH
	Output: Tie

#### Reversi :

	Reversi is a board game for two players. The board contains
	8x8 squares. The players place Black or White counters onto
	the board, one counter per square. More information can be
	found on Wikipedia en.wikipedia.org/wiki/Reversi?. Your task
	is to write a program that takes a current board position
	together with information about whose turn it is, and returns
	a list of the legal moves for that player. A move is only legal
	if it results in at least one of the opponent's counters being
	flipped.

	Example input: (the final B indicates it is Black's turn)
	........
	........
	........
	...BW...
	...WB...
	........
	........
	........
	B

	Example output: (each zero indicates a legal move for Black)
	........
	........
	....0...
	...BW0..
	..0WB...
	...0....
	........
	........
	B

#### Yehtzee :

	The game of yahtzee is a simple dice game. Each player rolls five
	six-sided dice. They can re-roll some or all of the dice up to three
	times (including the original roll).

	For example, suppose a players rolls
		3,4,5,5,2
	They hold the two fives and re-roll the other three dice (3,4,2)
		5,1,5,5,3
	They hold the three fives and re-roll the other two dice (1,3)
		5,6,5,5,2

	The player then places the roll in a category, such as ones, twos, fives,
	pair, two pairs etc (see below). If the roll is compatible with the category,
	the player gets a score for the roll according to the rules. If the roll is not
	compatible with the category, the player scores zero for the roll.

	For example, suppose a player scores 5,6,5,5,2 in the fives category they
	would score 15 (three fives). The score for that go is then added to their
	total and the category cannot be used again in the remaining goes for that game.
	A full game consists of one go for each category. Thus, for their last go in
	a game, a player must choose their only remaining category.

	Your task is to score a GIVEN roll in a GIVEN category.
	You do NOT have to program the random dice rolling.
	The game is NOT played by letting the computer choose the highest scoring
	category for a given roll.


	Yahzee Categories and Scoring Rules
	===================================

	Chance:
	  The player scores the sum of all dice, no matter what they read.
	  For example,
	   1,1,3,3,6 placed on "chance" scores 14 (1+1+3+3+6)
	   4,5,5,6,1 placed on "chance" scores 21 (4+5+5+6+1)

	Yahtzee:
	  If all dice have the same number, the player scores 50 points.
	  For example,
	   1,1,1,1,1 placed on "yahtzee" scores 50
	   1,1,1,2,1 placed on "yahtzee" scores 0

	Ones, Twos, Threes, Fours, Fives, Sixes:
	  The player scores the sum of the dice that reads one,
	  two, three, four, five or six, respectively.
	  For example,
	   1,1,2,4,4 placed on "fours" scores 8 (4+4)
	   2,3,2,5,1 placed on "twos" scores 4  (2+2)
	   3,3,3,4,5 placed on "ones" scores 0

	Pair:
	  The player scores the sum of the two highest matching dice.
	  For example, when placed on "pair"
	   3,3,3,4,4 scores 8 (4+4)
	   1,1,6,2,6 scores 12 (6+6)
	   3,3,3,4,1 scores 0
	   3,3,3,3,1 scores 0

	Two pairs:
	  If there are two pairs of dice with the same number, the
	  player scores the sum of these dice.
	  For example, when placed on "two pairs"
	   1,1,2,3,3 scores 8 (1+1+3+3)
	   1,1,2,3,4 scores 0
	   1,1,2,2,2 scores 0

	Three of a kind:
	  If there are three dice with the same number, the player
	  scores the sum of these dice.
	  For example, when placed on "three of a kind"
		3,3,3,4,5 scores 9 (3+3+3)
		3,3,4,5,6 scores 0
		3,3,3,3,1 scores 0

	Four of a kind:
	  If there are four dice with the same number, the player
	  scores the sum of these dice.
	  For example, when placed on "four of a kind"
		2,2,2,2,5 scores 8 (2+2+2+2)
		2,2,2,5,5 scores 0
		2,2,2,2,2 scores 0

	Small straight:
	  When placed on "small straight", if the dice read
	  1,2,3,4,5, the player scores 15 (the sum of all the dice.

	Large straight:
	  When placed on "large straight", if the dice read
	  2,3,4,5,6, the player scores 20 (the sum of all the dice).

	Full house:
	  If the dice are two of a kind and three of a kind, the
	  player scores the sum of all the dice.
	  For example, when placed on "full house"
		1,1,2,2,2 scores 8 (1+1+2+2+2)
		2,2,3,3,4 scores 0
		4,4,4,4,4 scores 0
---------------------------------------------------------------------

### Many more from [PragProg.com](http://codekata.pragprog.com/2007/01/code_kata_backg.html#more)

----------------------------------------------------------------------

### The Word Wrap Kata (via [CodingDojo](http://codingdojo.org/cgi-bin/wiki.pl?KataWordWrap))
	Create a function which breaks words on specified space with new line. Its nothing but merely similar to word-processor.

#### Steps:
		1. Create a public class named WordWrap
		2. Create a method 'wrap' it can be a static method
		3. Create a function which count the number of spliter words of non-space
		4. check for if words already having newline ['\n'] characters - ignore in counts
		5. Check for multiple lines
		6. Remove blank spaces if any in new line eg. Actual - "this is a test" WrappedText = "this\n is a t\nest"

--------------------------------------------------------------------------------------------------------------------------
### Natural Order String Sorting
--------------------------------------------------------------------------------------------------------------------------
### There is no built-in feature available in .Net to provide us Natural String Order Soring.

#### What is Natural Order String Sorting?
    Almost all framework provided ASCII order Sorting so, in case of string list : 1,2,3...,1A,2S the result would be as per ASCII order
	But in Natural Order String this should be : 1,1A,2,2S,3... etc.
References
====
* TDD-Kata Practices: http://tddkatas.codeplex.com/
* The Prime Factor Kata: http://butunclebob.com/ArticleS.UncleBob.ThePrimeFactorsKata
* The Bowling Game Kata: http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata
* More: http://codekata.pragprog.com/2007/01/code_kata_backg.html#more
* Word Wrap Kata: http://codingdojo.org/cgi-bin/wiki.pl?KataWordWrap
* String Calculator: http://osherove.com/tdd-kata-1/
