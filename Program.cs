using System;

namespace LineComparisionRemap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Computation :");
            LineComparision lineComparision = new LineComparision();
            lineComparision.FindLength();
            Console.ReadLine();
        }
    }
}
