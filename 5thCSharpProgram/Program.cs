using System;
using System.ComponentModel;

/*
This program is a more advanced calculator.
It gives the user 8 different options, add, subtract, multiply, divide, sqaure root, square, absolute value, and exit.
The user picks an operation, inputs number(s), and the calculator performs that operation. 
After that operation, the calculator takes the back to the menu to select another operation. Once they select exit, the program thanks them and ends.
 */


namespace fifthProgram
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(" Hello, this is my more advanced calculator!! ");
      Console.ReadLine();
      menu();
    }

    static void menu()
    {
      int options;

      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.ForegroundColor = ConsoleColor.White;

      Console.Clear();

      Console.WriteLine("        Menu");
      Console.WriteLine("______________________");
      Console.WriteLine();
      Console.WriteLine("1. Add");
      Console.WriteLine("2. Subtract");
      Console.WriteLine("3. Multiply");
      Console.WriteLine("4. Divide");
      Console.WriteLine("5. Square Roots");
      Console.WriteLine("6. Square / Power");
      Console.WriteLine("7. Absolute Value");
      Console.WriteLine("8. Factorial");
      Console.WriteLine("9. Exit");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Please select a number from the menu:");
      options = int.Parse(Console.ReadLine());

      switch (options)
      {
        case 1:
        add();
          break;
        case 2:
        subtract();
          break;
        case 3:
        multiply();
          break;
        case 4:
        divide();
          break;
        case 5:
        squareRoot();
          break;
        case 6:
        square();
          break;
        case 7:
        absoluteValue();
          break;
        case 8:
          factorial();
          break;
        case 9:
        exit();
          break;
        default:
        menu();
          break;
    }
    }
    static void add()
    {
      double number1;
      double number2;
      double answer;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input the first number for me to add:");
      number1 = int.Parse(Console.ReadLine());

      Console.WriteLine();
      Console.WriteLine("Please input the second number for me to add:");
      number2 = int.Parse(Console.ReadLine());

      answer = number1 + number2;

      Console.WriteLine();
      Console.WriteLine("{0} + {1} = {2}", number1, number2, answer);
      Console.ReadLine();
      menu();
    }
    static void subtract()
    {
      double number1;
      double number2;
      double answer;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input the first number for me to subtract:");
      number1 = int.Parse(Console.ReadLine());

      Console.WriteLine();
      Console.WriteLine("Please input the second number for me to subtract:");
      number2 = int.Parse(Console.ReadLine());

      answer = number1 - number2;

      Console.WriteLine();
      Console.WriteLine("{0} - {1} = {2}", number1, number2, answer);
      Console.ReadLine();
      menu();
    }
    static void multiply()
    {
      double number1;
      double number2;
      double answer;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input the first number for me to multiply:");
      number1 = int.Parse(Console.ReadLine());

      Console.WriteLine();
      Console.WriteLine("Please input the second number for me to multiply:");
      number2 = int.Parse(Console.ReadLine());

      answer = number1 * number2;

      Console.WriteLine();
      Console.WriteLine("{0} x {1} = {2}", number1, number2, answer);
      Console.ReadLine();
      menu();
    }
    static void divide()
    {
      double number1;
      double number2;
      double answer;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input the first number for me to divide:");
      number1 = int.Parse(Console.ReadLine());

      Console.WriteLine();
      Console.WriteLine("Please input the second number for me to divide:");
      number2 = int.Parse(Console.ReadLine());

      answer = number1 / number2;

      Console.WriteLine();
      Console.WriteLine("{0} / {1} = {2}", number1, number2, answer);
      Console.ReadLine();
      menu();
    }
    static void squareRoot()
    {
      double number;
      double answer;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input a number for me to find the square root of:");
      number = int.Parse(Console.ReadLine());

      answer = Math.Sqrt(number);

      Console.WriteLine();
      Console.WriteLine("The square root of {0} is {1}", number, answer);
      Console.ReadLine();
      menu();
    }
    static void square()
    {
      double number;
      double answer;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input a number for me to square:");
      number = int.Parse(Console.ReadLine());

      answer = Math.Pow(number, 2);

      Console.WriteLine();
      Console.WriteLine("{0} squared is {1}", number, answer);
      Console.ReadLine();
      menu();
    }
    static void absoluteValue()
    {
      double number;
      double answer;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input a number for me to find the absolute value of:");
      number = int.Parse(Console.ReadLine());

      answer = Math.Abs(number);

      Console.WriteLine();
      Console.WriteLine("The absolute value of {0} is {1}", number, answer);
      Console.ReadLine();
      menu();
    }
    static void factorial()
    {
      int number;
      int answer = 1;

      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Red;

      Console.Clear();

      Console.WriteLine("Please input a number for me to find the factorial of:");
      number = int.Parse(Console.ReadLine());

      for (int i = 1; i <= number; i++)
			{
        answer = answer * i;
			}
      Console.WriteLine();
      Console.WriteLine("The factorial of {0} is {1}.", number, answer);
      Console.ReadLine();
      menu();
    }
    static void exit()
    {
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();

      Console.WriteLine(" Thanks for using my more advanced calculator. Come back soon!!");
      Console.ReadLine();

      Environment.Exit(0);
    }

  }
}

