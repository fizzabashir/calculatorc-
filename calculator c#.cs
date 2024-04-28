
using System;
namespace APRILASSIGNMNT
{
    internal class Program
    {
        static void Main(string[] args)
        {
       while (true)
            {
           Console.WriteLine("Choose calculator type:");
           Console.WriteLine("1. Normal Calculator");
            Console.WriteLine("2. Scientific Calculator");
                Console.WriteLine("3. Exit");
  Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunNormalCalculator();
                        break;
                    case "2":
                        RunScientificCalculator();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the calculator. gudbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
  static void RunNormalCalculator()
           {
            Console.WriteLine("Normal Calculator");
            double num1, num2;
            char operation;

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Console.Write("Choose operation (+, -, *, /): ");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
     static void RunScientificCalculator()
        {
            Console.WriteLine("Scientific Calculator");
            double num;
            int operation;

            Console.Write("Enter a number: ");
            if (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Exponentiation (^)");
            Console.WriteLine("2. Square root");
            Console.WriteLine("3. Logarithm (base 10)");
            Console.WriteLine("4. Sine");
            Console.WriteLine("5. Cosine");
            Console.WriteLine("6. Tangent");

            Console.Write("Enter operation number: ");
            if (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid operation num.");
                return;
            }

            double result = 0;

            switch (operation)
            {
             case 1:
                    Console.Write("Enter exponent: ");
                    double exponent;
                    if (!double.TryParse(Console.ReadLine(), out exponent))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for exponent.");
                        return;
                    }
                    result = Math.Pow(num, exponent);
                    break;
            case 2:
                    if (num >= 0)
                        result = Math.Sqrt(num);
                    else
                        Console.WriteLine("Error: Square root of a -tive number");
                    break;
             case 3:
                    if (num > 0)
                        result = Math.Log10(num);
                    else
                        Console.WriteLine("Error: Logarithm of a nonpositive number");
                    break;
             case 4:
                    result = Math.Sin(num);
                    break;
             case 5:
                    result = Math.Cos(num);
                    break;
            case 6:
                    result = Math.Tan(num);
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
 }

