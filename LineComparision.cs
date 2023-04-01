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
        public double LengthOfLine1;
        public double LengthOfLine2;
        public double FindLength() {
         Console.WriteLine("Enter the Four End Points To calculate Length ");
         x1 = double.Parse(Console.ReadLine());
         y1 = double.Parse(Console.ReadLine());
         x2 = double.Parse(Console.ReadLine());
         y2 = double.Parse(Console.ReadLine());
         LengthOfLine= Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
         return LengthOfLine;
        }
        public void IsEqualOfLength() {
            LengthOfLine1 = FindLength();
            LengthOfLine2 = FindLength();
            if (LengthOfLine1 == LengthOfLine2) {
                Console.WriteLine("Two Lines Are Equal ");
            }
            else
            {
                Console.WriteLine("Two Line are Not Equal");
            }
        }
        public void IsEqualOfLength2()
        {
            LengthOfLine1 = FindLength();
            LengthOfLine2 = FindLength();
            double compareValue=LengthOfLine1.CompareTo(LengthOfLine2);
            if (compareValue > 0)
            {
                Console.WriteLine("First Line is Greateer Than Second Line  ");
            }
            else if (compareValue < 0)
            {
                Console.WriteLine("Second Line is Greater than First Line ");
            }
            else
            {
                Console.WriteLine("Two Line Length are Equal  ");
            }
        }


    }
}


