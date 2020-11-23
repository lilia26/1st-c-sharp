/*
This code asks the user for their first name
Then it asks the user to input two numbers
Then it asks for the user to pick an operation, addition, subtraction, multiplication, division, and power, and performs that operation
The program gives the answer to the user
The program loops five times, each time the user inputs a new set of numbers and a new operation
After all the loops the program thanks the user and asks them to come back
 */

using System;
using System.Diagnostics.CodeAnalysis;

namespace _4thCSharpProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName;
			double firstNumber;
			double secondNumber;
			string operation;
			double answer;

			Console.WriteLine("Please enter your first name.");
			firstName = Console.ReadLine();

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Please enter a number.");
				firstNumber = int.Parse(Console.ReadLine());

				Console.WriteLine("Please enter a second number.");
				secondNumber = int.Parse(Console.ReadLine());

				Console.WriteLine("Which operation would you like me to perform? Please answer with + (addition), - (subtraction), * (multiplication), / (division), or ^ (power).");
				operation = Console.ReadLine();

				switch (operation.Trim().ToLower())
				{
					case "sum":
					case "addition":
					case "+":
						answer = firstNumber + secondNumber;
						Console.WriteLine("{0}, the sum of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					case "difference":
					case "subtraction":
					case "-":
						answer = firstNumber - secondNumber;
						Console.WriteLine("{0}, the difference of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					case "product":
					case "multiplication":
					case "x":
					case "*":
						answer = firstNumber * secondNumber;
						Console.WriteLine("{0}, the product of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					case "quotient":
					case "division":
					case "/":
						answer = firstNumber / secondNumber;
						Console.WriteLine("{0}, the quotient of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					case "power":
					case "exponent":
					case "^":
						answer = Math.Pow(firstNumber, secondNumber);
						Console.WriteLine("{0}, {1} to the power of {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					default:
						Console.WriteLine("Sorry, I didn't understand your input.");
						break;
				}
				Console.ReadLine();
				Console.Clear();
			}
			Console.WriteLine("Thank you for using my basic calculator {0}. Come back soon!", firstName);
			Console.ReadLine();
		}
	}
}
