using System;
/*
This program asks the user for their first and last names.
also asks the user for them to input two numbers
then it calculated and displays the sum of the numbers
last it thanks the user for using and asks them to come back.
*/

namespace _firstcode
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName;
			string lastName;
			int firstNumber = 0;
			int secondNumber = 0;
			int sum;

			Console.WriteLine(" Please input your first name: ");
			firstName = Console.ReadLine();

			Console.WriteLine(" Please input your last name: ");
			lastName = Console.ReadLine();

			while(true)
			{
				Console.WriteLine(" " + firstName + " Please input first number: ");
				try
				{
					firstNumber = int.Parse(Console.ReadLine());
					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine(" You entered an invalid value. Please try again and input numbers only!");
				}
			}

			Console.WriteLine(" " + firstName + " Please input second number: ");
			secondNumber = int.Parse(Console.ReadLine());
	
			sum = firstNumber + secondNumber;

			Console.WriteLine(" " + firstName + " " + lastName + " the sum of " + firstNumber + " plus " + secondNumber + " is " + sum + ".");
			Console.WriteLine(" " + firstName + " Thanks for using my program! Come back again! ");
			Console.ReadLine();
		}
	}
}
