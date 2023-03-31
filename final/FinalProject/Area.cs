public class Area : Conversion
{
    private double _SquareM;
    private double _SquareFt;
    private double _Hectares;
    private double _SqYards;


    List<string> AUnitList = new List<string>();

    public Area() : base()
    {
        AUnitList.Add("Square Meter");
        AUnitList.Add("Square Foot");
        AUnitList.Add("Hectare");
        AUnitList.Add("Square Yard");


    }
    public override void Convert()
    {
        Console.WriteLine();
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
        _SquareM = number;
    }
    public void setSquareFt(double number)
    {
        _SquareFt = number;
    }

    public void setHectar(double number)
    {
        _Hectares = number;
    }

    public void setSqYards(double number)
    {
        _SqYards = number;
    }

    public List<string> getList()
    {
        return AUnitList;
    }

    public double ConvertSqmToSqft(double SquareM)
    {
        return (SquareM * 10.7639);
    }

    public double ConvertsqmTohectar(double SquareM)
    {
        return SquareM / 10000;
    }

    public double ConvertsqmTosqyrds(double SquareM)
    {
        return SquareM * 1.19599;
    }

    public double ConvertsqftTosqm(double SquareFt)
    {
        return SquareFt * 0.092903;
    }

    public double Convertsqfttohectar(double SquareFt)
    {
        return SquareFt * 0.0000092903;
    }

    public double ConvertsqftTosqyrds(double SquareFt)
    {
        return SquareFt / 9;
    }
    public double ConverthectarTosqm(double Hectares)
    {
        return Hectares * 10000;
    }

    public double ConverthectarTosqft(double Hectares)
    {
        return Hectares * 107639.1;
    }

    public double ConverthectarTosqyrds(double Hectares)
    {
        return Hectares * 11959.9;
    }

    public double ConvertsqyrdsTosqm(double SqYards)
    {
        return SqYards * 0.836127;
    }

    public double ConvertsqyrdsTosqft(double SqYards)
    {
        return SqYards * 9;
    }

    public double ConvertsqyrdsTohectar(double SqYards)
    {
        return (SqYards * 0.836127)/10000;
    }

}