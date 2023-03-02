public class Square : Shape
{
    private double _side;

    public Square()
    {  
    }

    public Square(string color, int side) : base(color)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return Math.Pow((_side), 2);
    }
}