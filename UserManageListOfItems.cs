using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
   public class UserManageListOfItems
   {
   }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
            
    //        List<string> list = new List<string>();

    //        while (true)
    //        {
                
    //            Console.WriteLine("Current List:");
    //            foreach (var item in list)
    //            {
    //                Console.WriteLine(item);
    //            }

    //            Console.WriteLine("\nEnter an operation (+ item, - item, -- to clear, or type 'exit' to quit):");
    //            string input = Console.ReadLine();

                
    //            if (input.ToLower() == "exit")
    //            {
    //                break;
    //            }

                
    //            if (input.StartsWith("+"))
    //            {
                    
    //                string itemToAdd = input.Substring(1).Trim();
    //                if (!string.IsNullOrEmpty(itemToAdd))
    //                {
    //                    list.Add(itemToAdd);
    //                    Console.WriteLine($"Added: {itemToAdd}");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Please specify an item to add.");
    //                }
    //            }
    //            else if (input.StartsWith("-"))
    //            {
                   
    //                string itemToRemove = input.Substring(1).Trim();
    //                if (list.Contains(itemToRemove))
    //                {
    //                    list.Remove(itemToRemove);
    //                    Console.WriteLine($"Removed: {itemToRemove}");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Item not found in the list.");
    //                }
    //            }
    //            else if (input == "--")
    //            {
    //                // Clear the list
    //                list.Clear();
    //                Console.WriteLine("List cleared.");
    //            }
    //            else
    //            {
    //                // Invalid input
    //                Console.WriteLine("Invalid input. Please enter a valid operation.");
    //            }

    //            // Add a separator for better readability
    //            Console.WriteLine("\n--------------------------------------------------\n");
    //        }

    //        // Final message when exiting
    //        Console.WriteLine("Goodbye!");
    //    }
    //}
}
