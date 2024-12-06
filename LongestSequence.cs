using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    internal class LongestSequence
    {
    }



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        
    //        Console.WriteLine("Enter an array of integers (space-separated):");
    //        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

    //        int maxLength = 1;  
    //        int currentLength = 1;  
    //        int longestElement = array[0];  
    //        int leftmostIndex = 0;  

    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            if (array[i] == array[i - 1])
    //            {
    //                currentLength++;

    //                // Update longest sequence details if necessary
    //                if (currentLength > maxLength)
    //                {
    //                    maxLength = currentLength;
    //                    longestElement = array[i];
    //                    leftmostIndex = i - maxLength + 1;
    //                }
    //            }
    //            else
    //            {
    //                currentLength = 1;  
    //            }
    //        }

    //        
    //        Console.WriteLine("Longest sequence:");
    //        Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestElement, maxLength)));
    //    }
    //}

}
