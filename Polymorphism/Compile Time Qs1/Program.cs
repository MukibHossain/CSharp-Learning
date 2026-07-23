//Compile - Time Polymorphism(Method Overloading)
//Create a class `Shape` with multiple overloaded 
//versions of a method `Area()`. Implement the 
//following overloads:-One that takes circle’s radius
//and returns its area.- Another that takes rectangle’s 
//width and height and returns its area.- One that takes square’s
//length of one line and returns its area.

using System;
class Shape
{ 
    //Circle
    public double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    //Rectangle
    public int Area(int width, int height)
    {
        return width * height;
    }

    //Square
    public int Area(int side)
    {
        return side * side;
    }
}

class program