using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Class3
    {
    }
}
//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static void Main()
//    {
//        int[,] array = {
//            { 1, 2, 3, 4 },
//            { 5, 6, 7, 8 },
//            { 9, 1, 2, 3 },
//            { 4, 5, 6, 7 }
//        };

//        Console.WriteLine("Original Array:");
//        Print2DArray(array);

//        RemoveDuplicates(ref array);

//        Console.WriteLine("Array after removing duplicates:");
//        Print2DArray(array);

//        // Hold the console window open
//        Console.WriteLine("Press Enter to exit...");
//        Console.ReadLine();
//    }

//    public static void RemoveDuplicates(ref int[,] array)
//    {
//        HashSet<int> uniqueNumbers = new HashSet<int>();
//        int rows = array.GetLength(0);
//        int cols = array.GetLength(1);

//        // First pass: collect unique numbers
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                uniqueNumbers.Add(array[i, j]);
//            }
//        }

//        // Second pass: fill the array with unique numbers
//        int uniqueIndex = 0;
//        int[] uniqueArray = new int[uniqueNumbers.Count];
//        uniqueNumbers.CopyTo(uniqueArray);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                if (uniqueIndex < uniqueArray.Length)
//                {
//                    array[i, j] = uniqueArray[uniqueIndex];
//                    uniqueIndex++;
//                }
//                else
//                {
//                    array[i, j] = 0; // Replace remaining elements with 0
//                }
//            }
//        }
//    }

//    public static void Print2DArray(int[,] array)
//    {
//        int rows = array.GetLength(0);
//        int cols = array.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write(array[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//Explanation:
//Main Method:

//Initializes a sample 2D array with duplicate numbers.
//Prints the original array.
//Calls RemoveDuplicates to remove duplicates from the array.
//Prints the modified array.
//RemoveDuplicates Method:

//Uses a HashSet<int> to collect unique numbers from the 2D array.
//Fills the 2D array again with these unique numbers.
//Replaces the remaining elements with 0 if there are fewer unique numbers than the total elements in the array.
//Print2DArray Method:

//Helper method to print the 2D array.

