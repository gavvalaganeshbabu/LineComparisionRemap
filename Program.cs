using System;

namespace LineComparisionRemap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Computation :");
            LineComparision lineComparision = new LineComparision();
            Console.WriteLine(lineComparision.FindLength());
            lineComparision.IsEqualOfLength();
            Console.ReadLine();
        }
    }
}
