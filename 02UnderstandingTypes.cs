using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2Day5
{
    public class _02UnderstandingTypes
    {
        // Method to display the size, min, and max values for numeric types
        public void DisplayNumericTypeInfo()
        {
            // Displaying size and range of each numeric type

            Console.WriteLine("sbyte:");
            Console.WriteLine($"Size in bytes: {sizeof(sbyte)}");
            Console.WriteLine($"Min value: {sbyte.MinValue}");
            Console.WriteLine($"Max value: {sbyte.MaxValue}\n");

            Console.WriteLine("byte:");
            Console.WriteLine($"Size in bytes: {sizeof(byte)}");
            Console.WriteLine($"Min value: {byte.MinValue}");
            Console.WriteLine($"Max value: {byte.MaxValue}\n");

            Console.WriteLine("short:");
            Console.WriteLine($"Size in bytes: {sizeof(short)}");
            Console.WriteLine($"Min value: {short.MinValue}");
            Console.WriteLine($"Max value: {short.MaxValue}\n");

            Console.WriteLine("ushort:");
            Console.WriteLine($"Size in bytes: {sizeof(ushort)}");
            Console.WriteLine($"Min value: {ushort.MinValue}");
            Console.WriteLine($"Max value: {ushort.MaxValue}\n");

            Console.WriteLine("int:");
            Console.WriteLine($"Size in bytes: {sizeof(int)}");
            Console.WriteLine($"Min value: {int.MinValue}");
            Console.WriteLine($"Max value: {int.MaxValue}\n");

            Console.WriteLine("uint:");
            Console.WriteLine($"Size in bytes: {sizeof(uint)}");
            Console.WriteLine($"Min value: {uint.MinValue}");
            Console.WriteLine($"Max value: {uint.MaxValue}\n");

            Console.WriteLine("long:");
            Console.WriteLine($"Size in bytes: {sizeof(long)}");
            Console.WriteLine($"Min value: {long.MinValue}");
            Console.WriteLine($"Max value: {long.MaxValue}\n");

            Console.WriteLine("ulong:");
            Console.WriteLine($"Size in bytes: {sizeof(ulong)}");
            Console.WriteLine($"Min value: {ulong.MinValue}");
            Console.WriteLine($"Max value: {ulong.MaxValue}\n");

            Console.WriteLine("float:");
            Console.WriteLine($"Size in bytes: {sizeof(float)}");
            Console.WriteLine($"Min value: {float.MinValue}");
            Console.WriteLine($"Max value: {float.MaxValue}\n");

            Console.WriteLine("double:");
            Console.WriteLine($"Size in bytes: {sizeof(double)}");
            Console.WriteLine($"Min value: {double.MinValue}");
            Console.WriteLine($"Max value: {double.MaxValue}\n");

            Console.WriteLine("decimal:");
            Console.WriteLine($"Size in bytes: {sizeof(decimal)}");
            Console.WriteLine($"Min value: {decimal.MinValue}");
            Console.WriteLine($"Max value: {decimal.MaxValue}\n");
        }
    }


    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
            
    //        _02UnderstandingTypes understandingTypes = new _02UnderstandingTypes();
            
    //        understandingTypes.DisplayNumericTypeInfo();

            
    //        Console.ReadLine();
    //    }
    //}
}

