using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    internal class SentenceReverse
    {
    }

//    class Program
//    {
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a sentence:");
//        string input = Console.ReadLine();

//        // Define separators as a regex pattern
//        string separators = @"[.,:;=()&[\]""'\\/!? ]+";

//        // Split the input into words and separators
//        string[] words = Regex.Split(input, separators, RegexOptions.Compiled);
//        string[] separatorsArray = Regex.Matches(input, separators)
//                                        .Select(match => match.Value)
//                                        .ToArray();

//        // Reverse the words
//        Array.Reverse(words);

//        // Reconstruct the sentence
//        string result = "";
//        int maxParts = Math.Max(words.Length, separatorsArray.Length);

//        for (int i = 0; i < maxParts; i++)
//        {
//            if (i < words.Length && !string.IsNullOrEmpty(words[i]))
//                result += words[i];

//            if (i < separatorsArray.Length)
//                result += separatorsArray[i];
//        }

//        Console.WriteLine("Reversed sentence:");
//        Console.WriteLine(result);
//    }
//}
}
