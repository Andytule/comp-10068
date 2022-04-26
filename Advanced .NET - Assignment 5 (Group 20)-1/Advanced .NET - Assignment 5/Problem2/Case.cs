using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Case
    {
        int Length;
        int Width;
        int Height;
        int FanCount;
        int VentCount;

        public Case(int length, int width, int height, int fanCount, int ventCount)
        {
            if (length >= 100)
            {
                throw new ArgumentOutOfRangeException("length", "Length can't be greater than 100 cm");
            }
            
            if (width >= 100)
            {
                throw new ArgumentOutOfRangeException("width", "Width can't be greater than 100 cm");
            }

            if (height >= 100)
            {
                throw new ArgumentOutOfRangeException("height", "Height can't be greater than 100 cm");
            }


            if (fanCount < 0 || fanCount > 12)
            {
                throw new ArgumentOutOfRangeException("fanCount", "Number of fans can't be less than 0 or greater than 12 ");
            }

            if (ventCount < 0 || ventCount > 12)
            {
                throw new ArgumentOutOfRangeException("ventCount", "Number of vents can't be less than 0 or greater than 12 ");
            }
            Length = length;
            Width = width;
            Height = height;
            FanCount = fanCount;
            VentCount = ventCount;
        }

        public override string ToString()
        {
            return $"Case: {Length}, {Width}, {Height}, {FanCount}, {VentCount}";
        }
    }
}
