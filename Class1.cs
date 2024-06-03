using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Class1
    {
    }
}
//using System;

//public class Program
//{
//    public static void Main()
//    {
//        string input = "Hello World";
//        string result = ReverseWords(input);
//        Console.WriteLine(result); // Output: "olleH dlroW"
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
//}

//Split the string into words.
//Reverse the characters in each word.
//Join the reversed words back into a single string.

//Explanation:
//Main Method: This is the entry point of the program. It defines an example input string and calls the ReverseWords method to reverse the characters in each word.

//ReverseWords Method:

//Splits the input string into an array of words using Split(' ').
//Iterates over each word and reverses it by calling the ReverseString method.
//Joins the reversed words back into a single string using string.Join(" ", words).
//ReverseString Method:

//Converts the string into a character array with ToCharArray().
//Reverses the character array using Array.Reverse(charArray).
//Converts the reversed character array back into a string with new string(charArray).
//You can replace the input string in the Main method with any string you want to reverse the words of.
