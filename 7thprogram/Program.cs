using System;
using System.Threading;

/*
This program asks the user for their name.
Then it plays a game
Two dice are rolled and the user must guess what those rolls were.
They may use hints, but less points are awarded for every hint used.
 */

namespace _7thprogram
{
	class Program
	{
		static void Main(string[] args)
		{
			int die1, die2;
			int choice1, choice2;
			int hint;

			Console.WriteLine("Please input your name:");
			string name = Console.ReadLine();

			Console.WriteLine("{0}, welcome to my game! This game will roll two dice, and you will guess the outcome of the dice rolls! Press enter to get started.", name);
			Console.ReadLine();

			Random randoms = new Random();
			die1 = randoms.Next(1, 7);
			die2 = randoms.Next(1, 7);
			Thread.Sleep(1500);

			while (true)
			{
				Console.WriteLine("Alright {0}, the dice have been rolled. If you would like to guess, type 1. If you would like a hint, type 2.", name);
				choice1 = int.Parse(Console.ReadLine());

				if (choice1 == 1 || choice1 == 2)
				{
					break;
				}
				Console.WriteLine("I did not understand your input. ");
			}

			if (choice1 == 1)
			{
				Guess(name, die1, die2, 0);
			}
			else
			{
				while (true)
				{
					Console.WriteLine("{0}, you have asked for a hint. Now, the maximum points you may receive is 6 points. If you would like one hint, type 1. If you would like two hints, type 2.", name);
					hint = int.Parse(Console.ReadLine());
					if (hint == 1 || hint == 2)
					{
						break;
					}
					Console.WriteLine("I did not understand your input. ");
				}

				if (hint == 1)
				{
					GiveFirstHint(name, die1, die2);

					while (true)
					{
						Console.WriteLine("Now that you have the hint, you can either guess or ask for another hint. Enter 1 for a guess and 2 for another hint.");
						choice2 = int.Parse(Console.ReadLine());
						if (choice2 == 1)
						{
							Guess(name, die1, die2, 1);
							break;
						}
						else if (choice2 == 2)
						{
							GiveSecondHint(name, die1, die2);
							Guess(name, die1, die2, 2);
							break;
						}
						else
						{
							Console.WriteLine("I did not understand your input. ");
						}
					}
				}
				else //hint == 2
				{
					GiveFirstHint(name, die1, die2);
					GiveSecondHint(name, die1, die2);
					Guess(name, die1, die2, 2);
				}
			}
			Console.ReadLine();
		}
		static void GiveFirstHint(string name, int die1, int die2)
		{
			int sum;

			Console.WriteLine("{0}, you have asked for a hint. Here it is:", name);
			sum = die1 + die2;
			Console.WriteLine("The first dice roll plus the second dice roll is equal to {0}", sum);
		}
		static void GiveSecondHint(string name, int die1, int die2)
		{
			int product;

			Console.WriteLine("{0}, you have asked for another hint. Here it is:", name);
			product = die1 * die2;
			Console.WriteLine("The first dice roll multiplied by the second dice roll is equal to {0}", product);
		}
		static void Guess(string name, int die1, int die2, int hintsused)
		{
			int guess1;
			int guess2;
			int points = 0;

			Console.WriteLine("{0}, now time to guess! First guess what the first die rolled:", name);
			guess1 = int.Parse(Console.ReadLine());
			Console.WriteLine("And now the second die:");
			guess2 = int.Parse(Console.ReadLine());

			if (guess1 == die1 || guess1 == die2)
			{
				points += 6;
				points -= (hintsused * 2);
			}
			if (guess2 == die1 || guess2 == die2)
			{
				points += 6;
				points -= (hintsused * 2);
			}
			if (points == 0)
			{
				Console.WriteLine("{0}, the first roll was a {1} and the second roll was a {2}. You received {3} points. Better luck next time!", name, die1, die2, points);
			}
			else
			{
				Console.WriteLine("{0}, the first roll was a {1} and the second roll was a {2}. You received {3} points. Congratulations!!", name, die1, die2, points);
			}
		}
		}
	}
