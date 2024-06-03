using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        public static void Main()
        {
            //string input;
            //input = Console.ReadLine();
            //string result = ReverseWords(input);
            //Console.WriteLine(result); // Output: "olleH dlroW"
            //Console.ReadLine();

            //string input = "hhhhhellllo world";
            //char result = FindThirdHighestCount(input);
            //if (result != '\0')
            //{
            //    Console.WriteLine($"The 3rd highest count character in the string \"{input}\" is: '{result}'");
            //}
            //else
            //{
            //    Console.WriteLine($"The string \"{input}\" does not have a third highest count character.");
            //}

            //// Hold the console window open
            //Console.WriteLine("Press Enter to exit...");
            //Console.ReadLine();
            Console.WriteLine("Enter a number greater than 10:");
            int input = int.Parse(Console.ReadLine());

            if (input <= 10)
            {
                Console.WriteLine("Please enter a number greater than 10.");
            }
            else
            {
                int result = MultiplyDigitsUntilSingleDigit(input);
                Console.WriteLine($"The resulting single digit is: {result}");
            }

            // Hold the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
        public static int MultiplyDigitsUntilSingleDigit(int num)
        {
            while (num >= 10)
            {
                num = MultiplyDigits(num);
            }
            return num;
        }

        public static int MultiplyDigits(int num)
        {
            int product = 1;

            while (num > 0)
            {
                int digit = num % 10;
                product *= digit;
                num /= 10;
            }

            return product;
        }
    }

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
    //public static string ReverseWords(string input)
    //{
    //    string[] words = input.Split(' ');

    //    for (int i = 0; i < words.Length; i++)
    //    {
    //        words[i] = ReverseString(words[i]);
    //    }

    //    return string.Join(" ", words);
    //}

    //public static string ReverseString(string s)
    //{
    //    char[] charArray = s.ToCharArray();
    //    Array.Reverse(charArray);
    //    return new string(charArray);
    //}
}

