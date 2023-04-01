public class Area : Conversion
{
    private double _squareMeter;
    private double _squareFoot;
    private double _hectares;
    private double _squareYards;


    List<string> AUnitList = new List<string>();

    public Area() : base()
    {
        AUnitList.Add("Square Meter");
        AUnitList.Add("Square Foot");
        AUnitList.Add("Hectare");
        AUnitList.Add("Square Yard");


    }

    public override int conversionFrom()
    {
        Console.Clear();
        Console.WriteLine("Please select converting from: ");
        Console.WriteLine();
        for (int i = 0; i < AUnitList.Count; i++)
        {
            string unitName = AUnitList[i];
            int index = (i + 1);
            Console.WriteLine($"{index}. {unitName}");
        }
        Console.WriteLine();
        Console.Write("Enter your choice: ");
        string _userChoice = Console.ReadLine();
        int userChoice = int.Parse(_userChoice);
        return userChoice;
    }

    public override int conversionTo(string userPick)
    {
        AUnitList.Remove(userPick);
        Console.Clear();
        Console.WriteLine("Please select converting to: ");
        Console.WriteLine();
        for (int i = 0; i < (AUnitList.Count); i++)
        {
            string unitName = AUnitList[i];
            int index = (i + 1);
            Console.WriteLine($"{index}. {unitName}");

        }
       
        Console.Write("Enter your choice: ");
        string _userChoice = Console.ReadLine();
        int userChoice = int.Parse(_userChoice);
        return userChoice;
    }

    public void setSquareM(double number)
    {
        _squareMeter = number;
    }
    public void setSquareFt(double number)
    {
        _squareFoot = number;
    }

    public void setHectar(double number)
    {
        _hectares = number;
    }

    public void setSqyards(double number)
    {
        _squareYards = number;
    }

    public List<string> getList()
    {
        return AUnitList;
    }

    public double ConvertSqmToSqft(double SquareM)
    {
        return (SquareM * 10.7639);
    }

    public double ConvertSqmToHectar(double SquareM)
    {
        return SquareM / 10000;
    }

    public double ConvertSqmToSqyrds(double SquareM)
    {
        return SquareM * 1.19599;
    }

    public double ConvertSqftToSqm(double SquareFt)
    {
        return SquareFt * 0.092903;
    }

    public double ConvertSqftToHectar(double SquareFt)
    {
        return SquareFt * 0.0000092903;
    }

    public double ConvertSqftToSqyrds(double SquareFt)
    {
        return SquareFt / 9;
    }
    public double ConvertHectarToSqm(double Hectares)
    {
        return Hectares * 10000;
    }

    public double ConvertHectarToSqft(double Hectares)
    {
        return Hectares * 107639.1;
    }

    public double ConvertHectarToSqyrds(double Hectares)
    {
        return Hectares * 11959.9;
    }

    public double ConvertSqyrdsToSqm(double SqYards)
    {
        return SqYards * 0.836127;
    }

    public double ConvertSqyrdsToSqft(double SqYards)
    {
        return SqYards * 9;
    }

    public double ConvertSqyrdsToHectar(double SqYards)
    {
        return (SqYards * 0.836127)/10000;
    }

}