using System;
using System.Collections.Generic;

class Database
{
    List<Shape3D> shapes = new List<Shape3D>();
    public void Print()
    {
        foreach (Shape3D shape in shapes)
        {
            Console.WriteLine(shape.GetType().Name);
            shape.ToString();
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine("Volume: " + shape.GetVolume());
            Console.WriteLine();
        }

    }

    public void AddShape3D(Shape3D shape)
    {
        shapes.Add(shape);
    }
}