using System;

namespace DataType
{
    class Programe
    {
        static void Main(string[] args)
        {
            // Integer Example - 4 Bytes
            // Explanation: The 'int' data type is used to store whole numbers and occupies 4 bytes of memory, ranging from -2,147,483,648 to 2,147,483,647.
            int myInteger = 100;
            Console.WriteLine($"Integer (4 bytes): {myInteger}");
            Console.WriteLine($"Data type of myInteger: {myInteger.GetType()}");

            // Float Example - 4 Bytes
            // Explanation: 'float' is a single-precision floating-point number, used for storing decimals, and requires the 'f' suffix. It uses 4 bytes of memory.
            float myFloat = 1.2345f;
            Console.WriteLine($"Float (4 bytes): {myFloat}");
            Console.WriteLine($"Data type of myFloat: {myFloat.GetType()}");

            // Double Example - 8 Bytes
            // Explanation: 'double' is a double-precision floating-point number, more precise than 'float', and occupies 8 bytes of memory.
            double myDouble = 3.14159;
            Console.WriteLine($"Double (8 bytes): {myDouble}");
            Console.WriteLine($"Data type of myDouble: {myDouble.GetType()}");

            // Long Example - 8 Bytes
            // Explanation: 'long' is used for large whole numbers and takes 8 bytes of memory, ranging from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            long myLong = 1234567890123456789;
            Console.WriteLine($"Long (8 bytes): {myLong}");
            Console.WriteLine($"Data type of myLong: {myLong.GetType()}");

            // Byte Example - 1 Byte
            // Explanation: 'byte' is an 8-bit unsigned integer ranging from 0 to 255, useful for small numbers.
            byte myByte = 255;
            Console.WriteLine($"Byte (1 byte): {myByte}");
            Console.WriteLine($"Data type of myByte: {myByte.GetType()}");

            // Short Example - 2 Bytes
            // Explanation: 'short' is a 16-bit signed integer, with a range from -32,768 to 32,767, and uses 2 bytes.
            short myShort = 30000;
            Console.WriteLine($"Short (2 bytes): {myShort}");
            Console.WriteLine($"Data type of myShort: {myShort.GetType()}");

            // Char Example - 2 Bytes
            // Explanation: 'char' stores a single 16-bit Unicode character and uses 2 bytes. Useful for storing individual characters.
            char myChar = 'C';
            Console.WriteLine($"Char (2 bytes): {myChar}");
            Console.WriteLine($"Data type of myChar: {myChar.GetType()}");

            // Bool Example - 1 Byte
            // Explanation: 'bool' is a Boolean data type that can be either true or false, occupying 1 byte.
            bool myBool = true;
            Console.WriteLine($"Bool (1 byte): {myBool}");
            Console.WriteLine($"Data type of myBool: {myBool.GetType()}");

            // String Example
            // Explanation: 'string' is a sequence of characters and is a reference type. Used for storing text.
            string myString = "Hello, C#";
            Console.WriteLine($"String: {myString}");
            Console.WriteLine($"Data type of myString: {myString.GetType()}");

            // Unsigned Integer (uint) - 4 Bytes
            // Explanation: 'uint' is a 32-bit unsigned integer with a range from 0 to 4,294,967,295, using 4 bytes.
            uint myUnsignedInt = 4000000000;
            Console.WriteLine($"Unsigned int (4 bytes): {myUnsignedInt}");
            Console.WriteLine($"Data type of myUnsignedInt: {myUnsignedInt.GetType()}");

            // Unsigned Long (ulong) - 8 Bytes
            // Explanation: 'ulong' is a 64-bit unsigned integer, used for very large numbers, using 8 bytes.
            ulong myUnsignedLong = 12345678901234567890;
            Console.WriteLine($"Unsigned long (8 bytes): {myUnsignedLong}");
            Console.WriteLine($"Data type of myUnsignedLong: {myUnsignedLong.GetType()}");

            // Decimal Example - 16 Bytes
            // Explanation: 'decimal' is used for high-precision financial and monetary calculations, using 16 bytes.
            decimal myDecimal = 199.99m;
            Console.WriteLine($"Decimal (16 bytes): {myDecimal}");
            Console.WriteLine($"Data type of myDecimal: {myDecimal.GetType()}");

            // Signed Byte (sbyte) - 1 Byte
            // Explanation: 'sbyte' is an 8-bit signed integer with a range from -128 to 127.
            sbyte mySignedByte = -100;
            Console.WriteLine($"Signed byte (1 byte): {mySignedByte}");
            Console.WriteLine($"Data type of mySignedByte: {mySignedByte.GetType()}");

            // Unsigned Short (ushort) - 2 Bytes
            // Explanation: 'ushort' is a 16-bit unsigned integer, ranging from 0 to 65,535, using 2 bytes.
            ushort myUnsignedShort = 65000;
            Console.WriteLine($"Unsigned short (2 bytes): {myUnsignedShort}");
            Console.WriteLine($"Data type of myUnsignedShort: {myUnsignedShort.GetType()}");

            // Implicit Conversion Example
            // Explanation: An 'int' can be implicitly converted to a 'long' without data loss.
            int myInt = 12345;
            long myImplicitLong = myInt; // Implicit conversion
            Console.WriteLine($"Implicit conversion from int to long: {myImplicitLong}");
            Console.WriteLine($"Data type of myImplicitLong: {myImplicitLong.GetType()}");

            // Explicit Conversion Example
            // Explanation: A 'double' must be explicitly converted to an 'int', which truncates the decimal part.
            double myDoubleNum = 123.456;
            int myExplicitInt = (int)myDoubleNum; // Explicit conversion
            Console.WriteLine($"Explicit conversion from double to int: {myExplicitInt}");
            Console.WriteLine($"Data type of myExplicitInt: {myExplicitInt.GetType()}");

            // Type Conversion Using ToString()
            // Explanation: The 'ToString()' method converts a numeric value to a string.
            int myIntToString = 789;
            string myStringConversion = myIntToString.ToString();
            Console.WriteLine($"Converted to string: {myStringConversion}");
            Console.WriteLine($"Data type of myStringConversion: {myStringConversion.GetType()}");

            // Reading User Input and Performing Operations
            Console.Write("Enter the value of x: ");
            string x = Console.ReadLine();
            Console.Write("Enter the value of y: ");
            string y = Console.ReadLine();
            int sum = Int32.Parse(x) + Int32.Parse(y);
            Console.WriteLine($"Addition of x and y is: {sum}");

            // Concatenating First and Last Names
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine($"Full name: {fullName.Trim()}");

            // Printing in Uppercase
            Console.WriteLine($"Full name in uppercase: {firstName.ToUpper()} {lastName.ToUpper()}");

            // Substring and IndexOf
            if (firstName.Length >= 2)
            {
                Console.WriteLine($"Substring from index 2: {firstName.Substring(2)}");
            }
            else
            {
                Console.WriteLine("First name is too short for a substring operation.");
            }
            char charToFind = 'a';
            Console.WriteLine($"Index of 'a' in last name: {lastName.IndexOf(charToFind)}");

            // Checking for Empty or Whitespace Strings
            bool isWhitespace = string.IsNullOrWhiteSpace(fullName);
            Console.WriteLine($"Is the full name empty or whitespace? {isWhitespace}");

            // Using Console.Read to Get ASCII Value
            Console.Write("Press a key to get its ASCII value: ");
            int asciiValue = Console.Read();
            Console.WriteLine($"\nASCII value: {asciiValue}");

            // Using Console.ReadKey to Capture a Key Press
            Console.Write("Press any key: ");
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            Console.WriteLine($"\nKey pressed: {keyPressed.Key}");
        }
    }
}
