﻿using System;

namespace FiguresLibrary
{
    public class Figure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public virtual double GetArea()
        {
            return Area;
        }
        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Area: {Math.Round(GetArea(),4)}");
            Console.WriteLine($"Perimeter: {Math.Round(GetPerimeter(),4)}");
        }

    }
}
