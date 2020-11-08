using System;
using System.Diagnostics.CodeAnalysis;

namespace _4thCSharpProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName;
			float firstNumber;
			float secondNumber;
			string operation;
			float answer;

			Console.WriteLine("Please enter your first name.");
			firstName = Console.ReadLine();

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Please enter a number.");
				firstNumber = int.Parse(Console.ReadLine());

				Console.WriteLine("Please enter a second number.");
				secondNumber = int.Parse(Console.ReadLine());

				Console.WriteLine("Which operation would you like me to perform? Please answer with addition, subtraction, multiplucation, or division.");
				operation = Console.ReadLine();

				switch (operation)
				{
					case "addition":
						answer = firstNumber + secondNumber;
						Console.WriteLine("{0}, the sum of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					case "subtraction":
						answer = firstNumber - secondNumber;
						Console.WriteLine("{0}, the difference of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					case "muktiplucation":
						answer = firstNumber * secondNumber;
						Console.WriteLine("{0}, the product of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					case "division":
						answer = firstNumber / secondNumber;
						Console.WriteLine("{0}, the quocient of {1} and {2} is {3}.", firstName, firstNumber, secondNumber, answer);
						break;
					default:
						Console.WriteLine("Sorry, I didn't understand your input.");
						break;
				}
				Console.ReadLine();
				Console.Clear();
			}
		}
	}
}
