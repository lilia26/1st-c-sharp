using System;
using System.Threading;

namespace _6thprogram
{
	class Program
	{
		static string name; 
		static void Main(string[] args)
		{
			GetName();
			Random();
		}
		static void GetName()
		{
			Console.WriteLine("Please input your name: ");
			name = Console.ReadLine();
		}
		static void Random()
		{
			int rand;
			int choice;
			int counter = 0;
			const int maxRolls = 10;

			Console.WriteLine("{0}, lets play a game!", name);

			for (int i = 1; i <= maxRolls; i++)
			{
				Random randoms = new Random();
				rand = randoms.Next(0, 2);

				Console.WriteLine("{0}, this is your roll #{1} out of {2}. Please guess heads or tails by selecting 0 for heads and 1 for tails", name, i, maxRolls);

				choice = int.Parse(Console.ReadLine());

				if (choice != 0 && choice != 1)
				{
					Console.WriteLine("Sorry, but your input was not valid. Please try again.");
					i--;
					continue;
				}

				Console.Write("You picked {0}. Flipping the coin... ", (choice == 0 ? "heads" : "tails"));
				Thread.Sleep(1500);
				Console.WriteLine(" the coin landed on {0}.", (rand == 0 ? "heads" : "tails"));

				if (rand == choice)
				{
					counter++;
					Console.WriteLine("{0}, you got it! Good job! Click enter to roll again.", name);
				}
				else
				{
					Console.WriteLine("{0}, sorry, but your guess is incorrect! Click enter to roll again.", name);
				}
				Console.ReadLine();
			}
			Console.WriteLine("{0}, your score was {1} out of 10!", name, counter);
			switch (counter)
			{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					Console.WriteLine("{0}, you lose!", name);
					break;
				case 5:
					Console.WriteLine("{0}, play again!", name);
					Random();
					break;
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					Console.WriteLine("{0}, congratulations, you win!!", name);
					break;
			}
			Console.ReadLine();
		}	
	}
}
