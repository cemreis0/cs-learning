using Cet.Point; // To use something from a namespace we use "using"

namespace CET301Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enumeration
            Console.WriteLine(CetColor.Red);
            Console.WriteLine(CetColor.Green);

            CetColor myColor = CetColor.Red;

            if (myColor == CetColor.Red)
                Console.WriteLine("myColor is red");
            else
                Console.WriteLine("myColor is not red");

            Console.WriteLine("The value of white is " + (int) CetColor.White);

            // Array
            int[] primes0; // Declaration
            int[] primes1 = new int[9]; // Allocation
            int[] primes2 = new int[] { 2, 3, 5, 7, 9 }; // Initialization
            int[] primes3 = { 2, 3, }; // Initialization
            int[,] matrix = new int[2, 3]; // Multidimensional array, rectangular matrix, can initialize declaratively

            // Class vs Struct
            // Class reference type
            PointC p1 = new PointC() { PointX = 1, PointY = 1 };
            PointC p2 = new PointC() { PointX = 2, PointY = 2 };

            p1 = p2;

            p1.PointX = -1;

            Console.WriteLine($"p1.PointX = {p1.PointX}, p1.PointY = {p1.PointY}");
            Console.WriteLine($"p2.PointX = {p2.PointX}, p2.PointY = {p2.PointY}");

            // Struct value type
            PointS p3 = new PointS() { PointX = 3, PointY = 3 };
            PointS p4 = new PointS() { PointX = 4,  PointY = 4 };

            p3 = p4;

            p3.PointX = -1;

            Console.WriteLine($"p3.PointX = {p3.PointX}, p3.PointY = {p3.PointY}");
            Console.WriteLine($"p4.PointX = {p4.PointX}, p4.PointY = {p4.PointY}");
        }
    }
}

// Enumeration
[Flags]
public enum CetColor: byte
{
    Red = 1,
    Green = 2,
    Blue = 4,
    Black = 0,
    White = Red | Green | Blue, // Bitwise OR
}