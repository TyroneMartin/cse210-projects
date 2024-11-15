using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }


    public override double GetArea()
    {
        return _width * _length;
    }


    // public double GetPerimeter()
    // {
    //     return 2 * (_width + _length);
    // }

    public GetLength()
    {
        return _length;
    }

    public GetWidth()
    {
        return _width;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }







}