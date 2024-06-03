using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Class4
    {
    }
}
//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter a number greater than 10:");
//        int input = int.Parse(Console.ReadLine());

//        if (input <= 10)
//        {
//            Console.WriteLine("Please enter a number greater than 10.");
//        }
//        else
//        {
//            int result = MultiplyDigitsUntilSingleDigit(input);
//            Console.WriteLine($"The resulting single digit is: {result}");
//        }

//        // Hold the console window open
//        Console.WriteLine("Press Enter to exit...");
//        Console.ReadLine();
//    }

//    public static int MultiplyDigitsUntilSingleDigit(int num)
//    {
//        while (num >= 10)
//        {
//            num = MultiplyDigits(num);
//        }
//        return num;
//    }

//    public static int MultiplyDigits(int num)
//    {
//        int product = 1;

//        while (num > 0)
//        {
//            int digit = num % 10;
//            product *= digit;
//            num /= 10;
//        }

//        return product;
//    }
//}

//Explanation:
//Main Method:

//Prompts the user to enter a number greater than 10.
//Reads the input number and checks if it is greater than 10.
//Calls MultiplyDigitsUntilSingleDigit method to get the resulting single digit.
//Prints the resulting single digit.
//MultiplyDigitsUntilSingleDigit Method:

//Continuously multiplies the digits of the number until the result is a single digit.
//Uses a while loop to call MultiplyDigits as long as the number has more than one digit.
//MultiplyDigits Method:

//Multiplies all the digits of the number.
//Extracts digits using modulo and integer division.

