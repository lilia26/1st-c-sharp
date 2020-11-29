using System;

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

			Console.WriteLine("{0}, 0 is for Heads and 1 is for tails", name);

			for (int i = 1; i <= 10; i++)
			{
				Random randoms = new Random();
				rand = randoms.Next(0, 2);

				Console.WriteLine("{0}, please guess heads or tails by selecting 0 for heads and 1 for Tails", name);
				choice = int.Parse(Console.ReadLine());

				if (rand == choice)
				{
					Console.WriteLine("{0}, you got it! Good job!", name);
					counter = counter + 1;
				}
				else
				{
					Console.WriteLine("{0}, sorry, but your guess is incorrect!", name);
				}
				Console.ReadLine();
			}
			Console.WriteLine("{0}, your score was {1} out of 10!", name, counter);
			switch (counter)
			{
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
