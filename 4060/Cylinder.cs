using System;
using System.Collections.Generic;

class Cylinder : Shape3D
{
    private double radius;
    private double height;
    
    public Cylinder(double aRadius, double aHeight)
    {
        radius = aRadius;
        height = aHeight;

    }
    public double GetArea()
    {
        return 2 * Math.PI * radius * height + 2 * Math.PI * radius * radius;
    }
    public double GetVolume()
    {
        return Math.PI * radius * height + 2 * Math.PI * radius * radius;
    }
    public void ToString()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Height: " + height);
    }

}