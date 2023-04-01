using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LineComparisionRemap
{
    internal class LineComparision
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        public double LengthOfLine;
        public void FindLength() {
         Console.WriteLine("Enter the Four End Points To calculate Length ");
         x1 = double.Parse(Console.ReadLine());
         y1 = double.Parse(Console.ReadLine());
         x2 = double.Parse(Console.ReadLine());
         y2 = double.Parse(Console.ReadLine());
         LengthOfLine= Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
         Console.WriteLine(LengthOfLine+" Is the Length of the Line ");
        }
        
    }
}


