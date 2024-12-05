using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    public class PrintPyramid
    {
        private int rows;
        public PrintPyramid()
        {
            rows = 5;
        }

        public void pyramidCreation ()
        {
            for (int i = 1; i <= rows; i++) // Outer loop for each row
            {
                // First inner loop: Print spaces
                for (int j = rows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                // Second inner loop: Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            PrintPyramid printPyramid = new PrintPyramid();
            printPyramid.pyramidCreation();
           
        }
    }


}
