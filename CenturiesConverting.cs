using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    using System;

    namespace Assignment2Day5
    {
        internal class CenturiesConverting
        {
            public void ConvertCenturies(int centuries)
            {
                
                long yearsInCentury = 100;

                
                double daysInYear = 365.24;

                
                long years = centuries * yearsInCentury;
                long days = (long)(years * daysInYear);
                long hours = days * 24;
                long minutes = hours * 60;
                long seconds = minutes * 60;
                long milliseconds = seconds * 1000;
                long microseconds = milliseconds * 1000;
                long nanoseconds = microseconds * 1000;

                
                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }

            //static void Main(string[] args)
            //{
            //    CenturiesConverting converting = new CenturiesConverting();


            //    Console.Write("Enter number of centuries: ");
            //    int centuries = int.Parse(Console.ReadLine());


            //    converting.ConvertCenturies(centuries);


            //    Console.ReadLine();
            //}
        }
    }

}
