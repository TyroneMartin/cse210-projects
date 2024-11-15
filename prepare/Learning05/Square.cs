using System;

public class Square : Shape
{

    private string _side;

    public Square(string color, string side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return double.Parse(_side) * double.Parse(_side);
    }

    public string GetSide()
    {
        return _side;
    }

    public void SetSide(string side)
    {
        _side = side;
    }


}