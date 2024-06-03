using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class palindrome
    {
    }
}
//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter a string:");
//        string input = Console.ReadLine();
//        string result = ReverseWords(input);
//        Console.WriteLine("Reversed words: " + result);

//        // Check if the reversed string is a palindrome
//        bool isPalindrome = IsPalindrome(result);
//        if (isPalindrome)
//        {
//            Console.WriteLine("The reversed string is a palindrome.");
//        }
//        else
//        {
//            Console.WriteLine("The reversed string is not a palindrome.");
//        }

//        // Hold the console window open
//        Console.WriteLine("Press Enter to exit...");
//        Console.ReadLine();
//    }

//    public static string ReverseWords(string input)
//    {
//        // Split the input string into words
//        string[] words = input.Split(' ');

//        // Reverse each word
//        for (int i = 0; i < words.Length; i++)
//        {
//            words[i] = ReverseString(words[i]);
//        }

//        // Join the reversed words back into a single string
//        return string.Join(" ", words);
//    }

//    public static string ReverseString(string s)
//    {
//        char[] charArray = s.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }

//    public static bool IsPalindrome(string s)
//    {
//        // Remove spaces and punctuation from the string
//        string cleanString = new string(s.Where(char.IsLetterOrDigit).ToArray());

//        // Convert the string to lowercase
//        cleanString = cleanString.ToLower();

//        // Compare the clean string with its reverse
//        string reversedString = ReverseString(cleanString);
//        return cleanString == reversedString;
//    }
//}
