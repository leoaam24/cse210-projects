public class Area : Conversion
{
    private double _SquareM;
    private double _SquareFt;
    private double _Hectares;
    private double _SqYards;


    List<string> AUnitList = new List<string>();

    public Area() : base()
    {
        AUnitList.Add("SquareM");
        AUnitList.Add("SquareFt");
        AUnitList.Add("Hectars");
        AUnitList.Add("SqYards");


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

    public double ConvertSqmToSqft()
    {
        return (_SquareM * 10.7639);
    }

    public double ConvertsqmTohectar()
    {
        return _SquareM / 10000;
    }

    public double ConvertsqmTosqyrds()
    {
        return _SquareM * 1.19599;
    }

    public double ConvertsqftTosqm()
    {
        return _SquareFt * 0.092903;
    }

    public double Convertsqfttohectar()
    {
        return _SquareFt * 0.0000092903;
    }

    public double ConvertsqftTosqyrds()
    {
        return _SquareFt / 9;
    }
    public double ConverthectarTosqm()
    {
        return _Hectares * 10000;
    }

    public double ConverthectarTosqft()
    {
        return _Hectares * 107639.1;
    }

    public double ConverthectarTosqyrds()
    {
        return _Hectares * 11959.9;
    }

    public double ConvertsqyrdsTosqm()
    {
        return _SqYards * 0.836127;
    }

    public double ConvertsqyrdsTosqft()
    {
        return _SqYards * 9;
    }

    public double ConvertsqyrdsTohectar()
    {
        return (_SqYards * 0.836127)/10000;
    }

}