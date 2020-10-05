using System;
using System.Collections.Generic;

class Cube : Shape3D
{
private double length;

    public Cube(double aLenght)
    {
        length = aLenght;
    }   

    public double GetArea()
    {
        return 6 * length * length;

    }
    public double GetVolume()
    {
        return length * length * length;
    }




    public void ToString()
    {
        Console.WriteLine("lenght of side: " + length);
        
    }
}