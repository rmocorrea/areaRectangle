﻿using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

       
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
