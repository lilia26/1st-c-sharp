using System;

/*
This program asks the user to input their first name. 
Then it asks for the user to input a number from 1 to 15.
If the number is not from 1 to 15, the program shows the user a predefined quote.
If the number is from 1 to 15, the program shows the user the quote that corresponds to that number.
Then the program asks the user if they liked the quote they saw.
The program asks the user if they would like to see another	quote. If they answer yes, the program loops back to the beginning. If they answer no, the program continues.
Lastly, the program thanks the user for using the program, and asks them to come back soon.
 */
namespace _LiliaShmulensonInspirationalQuotes
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName;
			int number;
			string word;

			Console.WriteLine("Please input your first name.");
			firstName = Console.ReadLine();

			while (true)
			{
				Console.WriteLine("{0}, please input a number from 1 to 15.", firstName);
				number = int.Parse(Console.ReadLine());

				if ((number > 15) || (number <= 0))
				{
					Console.WriteLine("Sorry, {0}, your number was not from 1 to 15. I am going to show you my favorite quote.", firstName);
					number = 6;
				}
				switch (number)
				{
					case 1:
						Console.WriteLine("{0}, quote number {1} is: Sometimes you will never know the value of a moment, until it becomes a memory. - Dr. Seuss", firstName, number);
						break;
					case 2:
						Console.WriteLine("{0}, quote number {1} is: Believe you can and you're halfway there. - Theodore Roosevelt", firstName, number);
						break;
					case 3:
						Console.WriteLine("{0}, quote number {1} is: When you have a dream, you've got to grab it and never let go. - Carol Burnett", firstName, number);
						break;
					case 4:
						Console.WriteLine("{0}, quote number {1} is: Happiness often sneaks in through a door you didn't know you left open. - John Barrymore", firstName, number);
						break;
					case 5:
						Console.WriteLine("{0}, quote number {1} is: A champion is defined not by their wins but by how they can recover when they fall. - Serena Williams", firstName, number);
						break;
					case 6:
						Console.WriteLine("{0}, quote number {1} is: Nothing is impossible. The word itself says 'I'M POSSIBLE'. - Audrey Hepburn", firstName, number);
						break;
					case 7:
						Console.WriteLine("{0}, quote number {1} is: The bad news is time flies. The good news is you're the pilot. - Michael Altshuler", firstName, number);
						break;
					case 8:
						Console.WriteLine("{0}, quote number {1} is: Happiness is not by chance, but by choise. - Jim Rohn", firstName, number);
						break;
					case 9:
						Console.WriteLine("{0}, quote number {1} is: Be the change that you wish to see in the world. - Mahatma Gandhi", firstName, number);
						break;
					case 10:
						Console.WriteLine("{0}, quote number {1} is: It isn't where you came from. It's where you're going that counts. - Ella Fitzgerald", firstName, number);
						break;
					case 11:
						Console.WriteLine("{0}, quote number {1} is: You get what you give. - Jennifer Lopez", firstName, number);
						break;
					case 12:
						Console.WriteLine("{0}, quote number {1} is: What you get by achieving your goals is not as important as what you become by achieving your goals. - Zig Ziglar", firstName, number);
						break;
					case 13:
						Console.WriteLine("{0}, quote number {1} is: Life is like riding a bicycle. To keep your BALANCE, you must keep moving. - Albert Einstein", firstName, number);
						break;
					case 14:
						Console.WriteLine("{0}, quote number {1} is: If I cannot do great things, I can do small things in a great way. - Martin Luther King Jr.", firstName, number);
						break;
					case 15:
						Console.WriteLine("{0}, quote number {1} is: It is never too late to be what you might have been. - George Eliot", firstName, number);
						break;
					default:
						Console.WriteLine("Sorry, I didn't understand your input. Please try again.");
						break;
				}

				Console.WriteLine("\n{0}, did you like the quote you read? Please respond with yes, maybe, or no.", firstName);
				word = Console.ReadLine();

				switch (word.Trim().ToLower())
				{
					case "yes":
						Console.WriteLine("Awesome! I'm so glad you liked it!");
						break;
					case "maybe":
						Console.WriteLine("Oh no, but I worked so hard!");
						break;
					case "no":
						Console.WriteLine("Aww that's too bad! I will try harder next time!");
						break;
					default:
						Console.WriteLine("Sorry, I didn't understand your word. Please try again.");
						break;
				}
				Console.WriteLine("{0}, would you like to see another quote? Please respond with yes or no.", firstName);
				word = Console.ReadLine();

				if (word.Trim().ToLower() == "yes")
					continue;

				break;
			}

			Console.WriteLine("{0}, thank you for using my inspirational quote engine! Please come back again to get inspired!", firstName);
			Console.ReadLine();
		}
	}
}
