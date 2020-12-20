using System;

namespace _8thprogram
{
	class Program
	{
		public class Global
		{
			public static int topside;
			public static int side;
			public static int bottomside;
			public static int area;
			public static int perimeter;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to my rectangle maker!");
			Console.WriteLine("Please enter a length for your rectangle.");
			Global.topside = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter a width for your rectangke.");
			Global.side = int.Parse(Console.ReadLine());
			Global.bottomside = Global.topside;
			start();
			topnumber();
			top();
			side();
			bottom();
			math();
			Console.ReadLine();
			Console.WriteLine("I hope you liked ny rectangle maker. Cone back soon!");
			Console.ReadLine();
		}
		static void start()
		{
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();

			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(" ");
			}
			Console.Write("                       ");
		}
		static void topnumber()
		{
			int midway = (Global.topside / 2) + 1;
			for (int i = 1; i<= midway; i++)
			{
				Console.Write(" ");
			}
			Console.Write(Global.topside);
			Console.WriteLine("");
			Console.Write("                       ");
		}
		static void top()
		{
			Console.Write("+");
			for (int i = 1; i<= Global.topside; i++)
			{
				Console.Write("-");
			}
			Console.Write("+");
			Console.WriteLine("");
			Console.Write("                       ");
		}
		static void side()
		{
			int midway = (Global.side / 2) + 1;
			for (int i = 1; i <= Global.side; i++)
			{
				Console.Write("|");
				for (int j = 1; j <= Global.topside; j++)
				{
					Console.Write(" ");
				}
				Console.Write("|");
				if (i == midway)
				{
					Console.Write(" {0}", Global.side);
				}
				Console.WriteLine("");
				Console.Write("                       ");
			}
		}
		static void bottom()
		{
			Console.Write("+");
			for (int i = 1; i <= Global.topside; i++)
			{
				Console.Write("-");
			}
			Console.Write("+");
			Console.Write("                       ");
		}
		static void math()
		{
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Global.area = Global.topside * Global.side;
			Global.perimeter = 2 * (Global.topside + Global.side);
			Console.WriteLine("The area of a rectangle with a length of {0} and a width of {1} is {2}, and the perimeter is {3}", Global.topside, Global.side, Global.area, Global.perimeter);
		}
	}
}
