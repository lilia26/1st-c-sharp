/*This program asks you for your first name
Then it asks you to input a number between 0 and 9, and checks to make sure If the number is not between 0 and 9, the program uses 5
The program also asks for a second number, checks it, and replaces it with 5 if it isn't between 0 and 9
Next the program adds the two numbers together, multiplies the two numbers, subtracts the first number from the second, and finds the absolute value of the difference.
Lastly the program thanks the user and asks them to come again*/

using System;

namespace _2ndprogram
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName;
			int firstNumber;
			int secondNumber;
			int sum;
			int difference;
			int product;
			int absoluteDifference;

			Console.WriteLine("Please input your first name:");
			firstName = Console.ReadLine();

			Console.WriteLine("Please input an number from 0 to 9.");
			firstNumber = int.Parse(Console.ReadLine());

			if (firstNumber >= 10)
			{
				Console.WriteLine("Hey {0}, The number should be less than 10! Instead of {1}, I will use 5.", firstName, firstNumber);
				firstNumber = 5;
			}
			else if (firstNumber < 0)
			{
				Console.WriteLine("Hey {0}, The number should be greater than 0! Instead of {1}, I will use 5.",firstName, firstNumber);
				firstNumber = 5;
			}
			else
			{
				Console.WriteLine("Great job!");
			}

			Console.WriteLine("Please input another number from 0 to 9.");
			secondNumber = int.Parse(Console.ReadLine());

			if (secondNumber >= 10)
			{
				Console.WriteLine("Hey {0}, The number should be less than 10! Instead of {1}, I will use 5.",firstName, secondNumber);
				secondNumber = 5;
			}
			else if (secondNumber < 0)
			{
				Console.WriteLine("Hey {0}, The number should be greater than 0! Instead of {1}, I will use 5.",firstName, secondNumber);
				secondNumber = 5;
			}
			else
			{
				Console.WriteLine("Great job!"); 
			}

			Console.WriteLine("Now, let's do some basic calculations!");

			sum = firstNumber + secondNumber;
			product = firstNumber * secondNumber;
			difference = secondNumber - firstNumber;
			absoluteDifference = Math.Abs(difference);

			Console.WriteLine("\n{0}, the sum of your numbers is {1}, the product of your numbers is {2}, the difference of your numbers is {3}, and the absolute value of the difference is {4}!", firstName, sum, product, difference, absoluteDifference);

			Console.WriteLine("Thanks for using my basic calculator! Come back soon!!");

			Console.ReadLine();
		}
	}
}
