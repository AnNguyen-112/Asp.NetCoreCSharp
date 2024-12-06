using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    internal class MostFrequentNumber
    {
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Input sequence of numbers
    //        Console.WriteLine("Enter a sequence of numbers (space-separated):");
    //        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    //        // Dictionary to store frequencies of each number
    //        Dictionary<int, int> frequency = new Dictionary<int, int>();

    //        // Track the most frequent number and its count
    //        int maxFrequency = 0;
    //        int mostFrequentNumber = numbers[0];

    //        foreach (int num in numbers)
    //        {
    //            if (!frequency.ContainsKey(num))
    //                frequency[num] = 0;

    //            frequency[num]++;

    //            // Update the most frequent number (check for leftmost)
    //            if (frequency[num] > maxFrequency ||
    //                (frequency[num] == maxFrequency && Array.IndexOf(numbers, num) < Array.IndexOf(numbers, mostFrequentNumber)))
    //            {
    //                maxFrequency = frequency[num];
    //                mostFrequentNumber = num;
    //            }
    //        }

    //        // Output the result
    //        Console.WriteLine($"The number {mostFrequentNumber} is the most frequent (occurs {maxFrequency} times).");
    //    }
    //}
}
