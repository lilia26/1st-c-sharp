/*
The program asks for the user's name
The program gives the user a menu to choose from
If they choose a square, then they enter a side value. The program draws a square with that value as a side length and gives the area and perimeter.
If they choose a rectangle, then then enter two side values and it draws a rectangle and gives the area and perimeter.
If they choose a cat, the program draws a funny cat from basic symbols.
If they choose to exit, the program simply closes.
*/
using System;

namespace _9thprogram
{
	class Program
	{
		public class Global
		{
			public static string name;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your name:");
			Global.name = Console.ReadLine();
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.ForegroundColor = ConsoleColor.White;
			ShowMenu();
		}
		static void ShowMenu()
		{
			int option;
			int side1;
			int side2;

			Console.Clear();

			Console.WriteLine("Menu");
			Console.WriteLine("___________________");
			Console.WriteLine();
			Console.WriteLine("1. Draw a Square");
			Console.WriteLine("2. Draw a Rectangle");
			Console.WriteLine("3. Draw a Cat");
			Console.WriteLine("4. Exit");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("{0}, please select a number from the menu.", Global.name);
			option = int.Parse(Console.ReadLine());

			switch (option)
			{
				case 1:
					Console.WriteLine("Please enter the side length:");
					side1 = int.Parse(Console.ReadLine());
					DrawSquare(side1);
					break;
				case 2:
					Console.WriteLine("Please enter the side length:");
					side1 = int.Parse(Console.ReadLine());
					Console.WriteLine("Please enter the side width:");
					side2 = int.Parse(Console.ReadLine());
					DrawRectangle(side1, side2);
					break;
				case 3:
					DrawCat();
					break;
				case 4:
					Console.Clear();
					Console.WriteLine("Thank you for using my basic geometry program. Come back soon!!");
					Console.ReadLine();
					Environment.Exit(0);
					break;
				default:
					ShowMenu();
					break;
			}
		}
		static void DrawSquare(int side1)
		{
			DrawRectangle(side1, side1);
		}
		static void DrawRectangle(int side1, int side2)
		{
			Console.Clear();
			DrawHorizontal(side1, true);
			DrawVertical(side1, side2);
			DrawHorizontal(side1, false);
			Calc(side1, side2);
			ShowMenu();
		}
		static void DrawHorizontal(int side1, bool IsShowNumber)
		{
			if (IsShowNumber)
			{
				int midway = (side1 / 2) + 1;
				for (int i = 1; i <= midway; i++)
				{
					Console.Write(" ");
				}
				Console.Write(side1);
				Console.WriteLine();
			}

			Console.Write("+");
			for (int i = 1; i <= side1; i++)
			{
				Console.Write("-");
			}
			Console.Write("+");
			Console.WriteLine();
		}
		static void DrawVertical(int side1, int side2)
		{
			int midway = (side2 / 2) + 1;
			for (int i = 1; i <= side2; i++)
			{
				Console.Write("|");
				for (int j = 1; j <= side1; j++)
				{
					Console.Write(" ");
				}
				Console.Write("|");
				if (i == midway)
				{
					Console.Write(side2);
				}
				Console.WriteLine();
			}
		}
		static void Calc(int side1, int side2)
		{
			int area;
			int perimeter;

			area = side1 * side2;
			perimeter = 2 * (side1 + side2);
			if (side1 == side2)
			{
				Console.WriteLine("{0}, a square with a side length of {1} has an area of {2} and a perimeter of {3}.", Global.name, side1, area, perimeter);
			}
			else
			{
				Console.WriteLine("{0}, a rectangle with a side length of {1} and a width of {2} has an area of {3} and a perimeter of {4}.", Global.name, side1, side2, area, perimeter);
			}
			Console.ReadLine();
		}
		static void DrawCat()
		{
			Console.Clear();
			Console.WriteLine("    /\\_____/\\");
			Console.WriteLine("   /  o   o  \\");
			Console.WriteLine("  ( ==  ^  == )");
			Console.WriteLine("   )         (");
			Console.WriteLine("  (           )");
			Console.WriteLine(" ( (  )   (  ) )");
			Console.WriteLine("(__(__)___(__)__)");
			Console.WriteLine("{0}, here is a cat! I hope you like it!!", Global.name);
			Console.ReadLine();
			ShowMenu();
		}
	}
}
