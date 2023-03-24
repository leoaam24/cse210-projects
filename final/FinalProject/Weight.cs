public class Weight : Conversion
{
    private double _MilliGram;
    private double _Gram;
    private double _Kilogram;
    private double _Pounds;


    List<string> WUnitList = new List<string>();

    public Weight() : base()
    {
        WUnitList.Add("Milligrams");
        WUnitList.Add("Grams");
        WUnitList.Add("Kilograms");
        WUnitList.Add("Pounds");


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
        for (int i = 0; i < WUnitList.Count; i++)
        {
            string unitName = WUnitList[i];
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
        WUnitList.Remove(userPick);
        Console.Clear();
        Console.WriteLine("Please select converting to: ");
        Console.WriteLine();
        for (int i = 0; i < (WUnitList.Count); i++)
        {
            string unitName = WUnitList[i];
            int index = (i + 1);
            Console.WriteLine($"{index}. {unitName}");

        }
       
        Console.Write("Enter your choice: ");
        string _userChoice = Console.ReadLine();
        int userChoice = int.Parse(_userChoice);
        return userChoice;
    }

    public void setMilliGrams(double number)
    {
        _MilliGram = number;
    }
    public void setGram(double number)
    {
        _Gram = number;
    }

    public void setKiloGram(double number)
    {
        _Kilogram = number;
    }

    public void setPounds(double number)
    {
        _Pounds = number;
    }

    

    public List<string> getList()
    {
        return WUnitList;
    }

    public double ConvertmgTog()
    {
        return _MilliGram / 1000;
    }

    public double ConvertmgTokg()
    {
        return _MilliGram / 1000000;
    }

    public double ConvertmgTolb()
    {
        return (_MilliGram/1000) * 0.00220462;
    }

    public double ConvergTomg()
    {
        return _Gram * 1000;
    }

    public double Convertgtokg()
    {
        return _Gram / 1000;
    }

    public double ConvertgTolb()
    {
        return _Gram / 453.59237;
    }  
    public double ConvertkgTomg()
    {
        return _Kilogram * 1000000;
    }
    
    public double ConvertkgTog()
    {
        return _Kilogram * 1000;
    }
    public double ConvertkgTolb()
    {
        return _Kilogram * 2.20462;
    }

    public double ConvertlbTomg()
    {
        return _Pounds * 453.59237 * 1000;
    }

    public double ConvertlbTog()
    {
        return _Pounds * 453.59237;
    }

    public double ConvertlbTokg()
    {
        return _Pounds * 0.45359237;
    }



    
}