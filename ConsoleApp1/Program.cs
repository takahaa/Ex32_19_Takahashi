﻿using System;
using AbstractSample;

namespace Ex32

{
    class Program
    {
        static void Main(string[] args)
        {
            //Surface testSurface = new Surface();  エラーになる
            Rectangle rectAngle1 = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(5, 4, 3);
            Surface[] surfaces = {rectAngle1,rightTriangle,circle,triangle};
            for(var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"surfacesの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"surfacesの周囲長は{surfaces[i].GetCircumference()}");
            }
        }
    }
}
