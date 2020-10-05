using System;
using System.Collections.Generic;

class Sphere : Shape3D
{
    private double radius;
    public Sphere(double aRadius)
    {
        radius = aRadius;
    }

    public double GetArea()
    {
        return 4 * Math.PI * radius * radius;

    }
    public double GetVolume()
    {
        return (4d/3d) * Math.PI * (radius * radius * radius);
    }

    public void ToString()
    {
        Console.WriteLine("Radius:" + radius);

    }



}