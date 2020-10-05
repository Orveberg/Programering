using System;
using System.Collections.Generic;
namespace _4060
{
    class Program
    {
        static void Main(string[] args)
        {
            Database myDatabase = new Database();
            myDatabase.AddShape3D(new Sphere(4));
            myDatabase.AddShape3D(new Cylinder(4, 6.0));
            myDatabase.AddShape3D(new Cube(3.0));
            myDatabase.Print();
        }
    }
}
