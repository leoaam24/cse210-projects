using System;

class Program
{
    static void Main(string[] args)
    {
        Square SqClass = new Square();
        SqClass.SetColor("blue");
        string squareColor = SqClass.GetColor();
        SqClass.SetSide(5);
        double squareArea = SqClass.GetArea();

        // Console.WriteLine();
        // Console.WriteLine(squareColor);
        // Console.WriteLine(squareArea);
        // Console.WriteLine();
        
        Rectangle ReClass = new Rectangle();
        ReClass.SetColor("red");
        string rectangleColor = ReClass.GetColor();
        ReClass.SetLength(5);
        ReClass.SetWidth(3);
        double rectangleArea = ReClass.GetArea();

        // Console.WriteLine();
        // Console.WriteLine(rectangleColor);
        // Console.WriteLine(rectangleArea);
        // Console.WriteLine();

        Circle CiClass = new Circle();
        CiClass.SetColor("yellow");
        string circleColor = CiClass.GetColor();
        CiClass.SetRadius(24);
        double circleArea = CiClass.GetArea();

        // Console.WriteLine();
        // Console.WriteLine(circleColor);
        // Console.WriteLine(circleArea);
        // Console.WriteLine();

        List<Shape> ShapeList = new List<Shape>();
        ShapeList.Add(SqClass);
        ShapeList.Add(ReClass);
        ShapeList.Add(CiClass);

        foreach(Shape Shape in ShapeList)
        {
            string color = Shape.GetColor();
            double area = Shape.GetArea();
            Console.WriteLine($"{color}: {area}");
        }

    }
}