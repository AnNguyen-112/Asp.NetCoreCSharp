using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    internal class PalindromesDectection
    {
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a text:");
    //        string input = Console.ReadLine();

          
    //        string[] words = Regex.Matches(input, @"\b\w+\b")
    //                              .Cast<Match>()
    //                              .Select(m => m.Value)
    //                              .ToArray();

            
    //        var palindromes = words.Where(IsPalindrome)
    //                               .Select(word => word.ToLower()) 
    //                               .Distinct() 
    //                               .OrderBy(word => word) 
    //                               .ToList();

            
    //        Console.WriteLine("Palindromes: " + string.Join(", ", palindromes));
    //    }

        
    //    static bool IsPalindrome(string word)
    //    {
    //        string reversed = new string(word.Reverse().ToArray());
    //        return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    //    }
    //}
}
