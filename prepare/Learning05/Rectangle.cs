using System;

class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(double length, double width, string color)
    {
        SetColor(color);
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length*_width;
    }
}