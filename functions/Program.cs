using System;

namespace DataType.functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the Printer() method
            Printer();

            // Calling the Add() method and printing the returned value
            Console.WriteLine(Add());

            // Calling the Sub() method with parameters 30 and 30, and printing the result
            Console.WriteLine(Sub(30, 30));

            // Calling the Calculater() method with arguments 4 and 2
            Calculater(4, 2);

            // Calling the Operators() method with arguments 2 and 2
            Operators(2, 2);

            // Example of Unary and Ternary Operators
            UnaryOperatorsExample();
            TernaryOperatorExample();
        }

        // Non-return type function: Printer()
        // Explanation: 
        // - 'void' indicates that the function does not return any value.
        // - This function prints a message to the console.
        public static void Printer()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine("Hi I'm Ulaganathan from the Printer function " + c);
            // Console.ReadKey() waits for a key press to keep the console window open.
            Console.ReadKey();
        }

        // Return type function: Add()
        // Explanation: 
        // - Returns the sum of two user-provided integers.
        public static int Add()
        {
            Console.Write("Enter the first value: ");
            string aa = Console.ReadLine();
            Console.Write("Enter the second value: ");
            string bb = Console.ReadLine();
            int num1 = Int32.Parse(aa);
            int num2 = Int32.Parse(bb);
            return num1 + num2;
        }

        // Parameterized function: Sub()
        // Explanation: 
        // - Accepts two integers and returns the result of their subtraction.
        public static int Sub(int cc, int cc1)
        {
            return cc - cc1;
        }

        // Function: Calculater()
        // Explanation:
        // - Demonstrates basic arithmetic operations: addition, subtraction, multiplication, and division.
        public static void Calculater(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition: {result}");
            result = a - b;
            Console.WriteLine($"Subtraction: {result}");
            result = a * b;
            Console.WriteLine($"Multiplication: {result}");
            result = a / b;
            Console.WriteLine($"Division: {result}");
        }

        // Function: Operators()
        // Explanation:
        // - Demonstrates the use of relational and logical operators.
        public static void Operators(int a, int b)
        {
            if (a < b)
                Console.WriteLine($"The value of a ({a}) is smaller than b ({b})");
            if (a > b)
                Console.WriteLine($"The value of a ({a}) is greater than b ({b})");
            if (a == b)
                Console.WriteLine($"The value of a ({a}) is equal to b ({b})");
            if (a != b)
                Console.WriteLine($"The value of a ({a}) is not equal to b ({b})");
            if (a <= b)
                Console.WriteLine($"The value of a ({a}) is less than or equal to b ({b})");
            if (a >= b)
                Console.WriteLine($"The value of a ({a}) is greater than or equal to b ({b})");
            if ((a != b) && (a < b))
                Console.WriteLine($"The value of a ({a}) is not equal to b ({b}) and a is less than b");
            if ((a == b) || (a < b))
                Console.WriteLine("The OR operator is used: if any one condition is true, it goes inside the block");
            else
                Console.WriteLine("The End");
        }

        // Function: UnaryOperatorsExample()
        // Explanation:
        // - Demonstrates the use of unary operators.
        public static void UnaryOperatorsExample()
        {
            int x = 5;
            Console.WriteLine($"Initial value of x: {x}");
            Console.WriteLine($"Post-increment: {x++}"); // x is 5, then incremented to 6
            Console.WriteLine($"Value after post-increment: {x}");
            Console.WriteLine($"Pre-increment: {++x}"); // x is incremented to 7, then printed as 7
            Console.WriteLine($"Post-decrement: {x--}"); // x is 7, then decremented to 6
            Console.WriteLine($"Value after post-decrement: {x}");
            Console.WriteLine($"Pre-decrement: {--x}"); // x is decremented to 5, then printed as 5
        }

        // Function: TernaryOperatorExample()
        // Explanation:
        // - Demonstrates the use of the ternary operator for conditional expressions.
        public static void TernaryOperatorExample()
        {
            int age = 20;
            string result = (age >= 18) ? "You are an adult." : "You are a minor.";
            Console.WriteLine(result);
        }
    }
}
