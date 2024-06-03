using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Class2
    {
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Program
//{
//    public static void Main()
//    {
//        string input = "hello world";
//        char result = FindThirdHighestCount(input);
//        Console.WriteLine($"The 3rd highest count character in the string \"{input}\" is: {result}");

//        // Hold the console window open
//        Console.WriteLine("Press Enter to exit...");
//        Console.ReadLine();
//    }

//    public static char FindThirdHighestCount(string input)
//    {
//        // Count the frequency of each character
//        Dictionary<char, int> charCount = new Dictionary<char, int>();
//        foreach (char c in input)
//        {
//            if (char.IsLetter(c)) // Considering only letters, ignoring spaces and other characters
//            {
//                if (charCount.ContainsKey(c))
//                {
//                    charCount[c]++;
//                }
//                else
//                {
//                    charCount[c] = 1;
//                }
//            }
//        }

//        // Sort the characters based on their frequencies in descending order
//        var sortedChars = charCount.OrderByDescending(pair => pair.Value);

//        // Find the third highest count
//        int count = 0;
//        char thirdHighestChar = '\0'; // Default value if there are less than 3 distinct characters
//        foreach (var pair in sortedChars)
//        {
//            count++;
//            if (count == 3)
//            {
//                thirdHighestChar = pair.Key;
//                break;
//            }
//        }

//        return thirdHighestChar;
//    }
//}

//To find the 3rd highest count of characters in a given string in C#, you can follow these steps:

//Count the frequency of each character in the string.
//Sort the characters based on their frequencies in descending order.
//Select the third highest count from the sorted frequencies.

//Explanation:
//Main Method:

//Calls the FindThirdHighestCount method with an example input string.
//Prints the result.
//FindThirdHighestCount Method:

//Counts the frequency of each character in the input string using a Dictionary< char, int>.
//Sorts the characters based on their frequencies in descending order using LINQ's OrderByDescending.
//Iterates over the sorted characters and returns the character corresponding to the third highest count.

//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Program
//{
//    public static void Main()
//    {
//        string input = "hello world";
//        char result = FindThirdHighestCount(input);
//        if (result != '\0')
//        {
//            Console.WriteLine($"The 3rd highest count character in the string \"{input}\" is: '{result}'");
//        }
//        else
//        {
//            Console.WriteLine($"The string \"{input}\" does not have a third highest count character.");
//        }

//        // Hold the console window open
//        Console.WriteLine("Press Enter to exit...");
//        Console.ReadLine();
//    }

//    public static char FindThirdHighestCount(string input)
//    {
//        // Count the frequency of each character
//        Dictionary<char, int> charCount = new Dictionary<char, int>();
//        foreach (char c in input)
//        {
//            if (char.IsLetter(c)) // Considering only letters, ignoring spaces and other characters
//            {
//                if (charCount.ContainsKey(c))
//                {
//                    charCount[c]++;
//                }
//                else
//                {
//                    charCount[c] = 1;
//                }
//            }
//        }

//        // Check if there are at least three distinct characters
//        if (charCount.Count < 3)
//        {
//            return '\0'; // Return null character if there are less than 3 distinct characters
//        }

//        // Sort the characters based on their frequencies in descending order
//        var sortedChars = charCount.OrderByDescending(pair => pair.Value).ToList();

//        // Find the third highest count
//        int thirdHighestFrequency = sortedChars[2].Value; // The frequency of the third highest count
//        var thirdHighestChars = sortedChars.Where(pair => pair.Value == thirdHighestFrequency).ToList();

//        // If there are multiple characters with the third highest frequency, return the first one
//        return thirdHighestChars.First().Key;
//    }
//}





