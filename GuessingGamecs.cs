using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    public class GuessingGamecs
    {
        private int _number;

        public GuessingGamecs(int number)
        {
            _number = number;
        }

        public void GuessingTheNumber ()
        {
            int correctNumber = new Random().Next(3) + 1;
            if (correctNumber < _number)
            {
                Console.WriteLine("Number too high");

            }
            else if (correctNumber > _number)
            {
                Console.WriteLine("Number too low");

            }
            else
            {
                Console.WriteLine("Congrats. Correct Number!");
            }
        }

        //public class Program
        //{
        //    static void Main(string[] args)
        //    {

        //        Console.Write("Please enter a number from 1 to 3: ");
        //        string userInput = Console.ReadLine();


        //        if (int.TryParse(userInput, out int guessedNumber) && guessedNumber >= 1 && guessedNumber <= 3)
        //        {
        //            GuessingGamecs game = new GuessingGamecs(guessedNumber);
        //            game.GuessingTheNumber();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        //        }

        //        Console.ReadLine();
        //    }
        //}

    }
}
