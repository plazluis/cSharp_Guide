using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Pratice
    {
        public static void Main()
        {
            ConditionalStatements.switchStatement.SwitchStatement();
        }
    }
}

namespace TextFiles
{
    public class FileReader
    {
        public static void File_Reader()
        {
            StreamReader reader = new StreamReader("--Place Path Here--");
            int lineNumber = 0;

            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;
                Console.WriteLine($"Line {lineNumber}: {line}");
                line = reader.ReadLine();
            }
            reader.Close();
        }
    }

    public class FileWriter
    {
        public static void File_Writer()
        {
            StreamWriter writer = new StreamWriter("--Place Path Here--");

            using (writer)
            {
                for (int i = 0; i <= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}

namespace ExceptionHandling
{
    public class Adding_Dividing_numbers
    {
        public static void Exception_Handling()
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int divisionResult = num1 / num2;
                Console.WriteLine($"\nDivision of the two number is: {divisionResult}");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nAn exception ocurred: " + e.Message);
            }
            finally
            {
                Console.WriteLine("\nThe sum of the two numbers is: " + (num1 + num2));
            }
        }
    }

}

namespace Recursion
{
    public class RecursiveFibonacciMemoization
    {
        public static void Run()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            long result = Fib(n);
            Console.WriteLine("fib({0}) = {1}", n, result);
        }
        public static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}

namespace Methods
{
    public class ReturnValueMethod
    {
        public static int addSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class VoidMethod
    {
        public static void ReturnString()
        {
            Console.WriteLine("This is a void method!");
        }
    }

    public class VoidMethod2
    {
        public static void addSum(int num1, int num2)
        {
            Console.WriteLine($"The sum of the number is: {num1 + num2}");
        }
    }

    public class ReturnValueAndVoidMethod
    {
        public static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            }
            return numbers;
        }

        public static void PrintingNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
                if (i < (numbers.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }

        public static void Solve()
        {
            int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);
            PrintingNumbers(numbers);
        }
    }
}

namespace Arrays
{
    public class CreatingAnArray
    {
        public static void CreatingAn_Array()
        {
            int[] myArray = new int[5];
        }
    }

    public class DeclarationAndInitializatoin
    {
        public static void Declare_Initialize_Array()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }
    }

    public class PrintingArray
    {
        public static void Printing_Array()
        {
            string[] array = { "one", "two", "three", "four" };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element[{i}] = {array[i]}");
            }
        }
    }

    public class MultidimensionalArrays
    {
        public static void Multi_Arrays()
        {
            int[,] matrix =
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Loops
{
    public class whileLoop
    {
        public static void while_Loop()
        {
            Console.Write("Enter a value for n: ");
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            int sum = 1;
            Console.Write($"\nThe sum 1");

            while (num < n)
            {
                num++;
                sum += num;
                Console.Write($" + {num}");
            }
            Console.Write($" = {sum}");
        }
    }

    public class doWhileLoop
    {
        public static void do_WhileLoop()
        {
            int i = 1, n = 5, product;
            do
            {
                product = n * i;
                Console.WriteLine($"{n} * {i} = {product}");
                i++;
            } while (i <= 10);
        }
    }

    public class forLoop
    {
        public static void for_Loop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Loop number: {i}");
            }
        }
    }

    public class foreachLoop
    {
        public static void forEach_Loop()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"This is the value for index {i}: {numbers[i]}.");
            }

            Console.WriteLine("\nNom I am going to multiply each number by 2.");
            foreach (int number in numbers)
            {
                Console.WriteLine($"{number * 2}");
            }
        }
    }
}

namespace ConditionalStatements
{
    public class ifStatement
    {
        public static void IfStatement()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"\n{num1} is greater than {num2}.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"\n{num2} is greater than {num1}.");
            }
            else
            {
                Console.WriteLine($"\nBoth numbers are equal.");
            }
        }
    }

    public class switchStatement
    {
        public static void SwitchStatement()
        {
            Console.Write("What is your grade for the latest exam: ");
            int grade = int.Parse(Console.ReadLine());

            switch (grade / 10)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("You received an F");
                    break;
                case 6:
                    Console.WriteLine("You received a D");
                    break;
                case 7:
                    Console.WriteLine("You received a C");
                    break;
                case 8:
                    Console.WriteLine("You received a B");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("You received an A");
                    break;
                default:
                    Console.WriteLine("Unknown grade");
                    break;
            }
        }
    }
}

namespace InputAndOutput
{
    public class ConsoleOutput
    {
        public static void Printing()
        {
            Console.WriteLine($"Hello World");
        }
    }

    public class ConsoleInput
    {
        public static void Getting()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("How old are you: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nHello {firstName}, you are {age} years old.");
        }
    }
}