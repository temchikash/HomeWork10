﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Circle : Point, ISquare
    {
        public double Radius { get; set; }

        public Circle(double radius, int x, int y, string color, condition condition) : base(x, y, color, condition)
        {
            Radius = radius;
        }



        public void Square()
        {
            Console.WriteLine($"Площадь круга равна : {Math.Round(Math.PI * Radius * Radius, 2)}");
        }
    }
}
