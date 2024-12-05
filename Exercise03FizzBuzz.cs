using Assignment2Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    public class Exercise03FizzBuzz
{
    private int _count;

    // Constructor to initialize the count
    public Exercise03FizzBuzz(int count)
    {
        _count = count;
    }

    // Method to execute FizzBuzz logic
    public void RunFizzBuzz()
    {
        for (int i = 1; i <= _count; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public void testingFunction()
    {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
}

//public class Program
//{
//    static void Main(string[] args)
//    {

//            Console.Write("Enter a number for FizzBuzz: ");
//            if (int.TryParse(Console.ReadLine(), out int count))
//            {
//                Exercise03FizzBuzz fizzBuzz = new Exercise03FizzBuzz(count);

//                // Run the FizzBuzz logic
//                fizzBuzz.RunFizzBuzz();
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter a valid integer.");
//            }

//            Console.ReadLine();

//            Exercise03FizzBuzz fizzBuzz2 = new Exercise03FizzBuzz(100);
//            fizzBuzz2.testingFunction();
//        }
//}
}
