public class Measurement2 : Conversion
{
    private double _Foot;
    private double _Meter;
    private double _Kilometer;
    private double _Miles;

    List<string> m2UnitList = new List<string>();

    public Measurement2() : base()
    {
        m2UnitList.Add("Foot");
        m2UnitList.Add("Meter");
        m2UnitList.Add("Kilometer");
        m2UnitList.Add("Miles");

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
        for (int i = 0; i < m2UnitList.Count; i++)
        {
            string unitName = m2UnitList[i];
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
        m2UnitList.Remove(userPick);
        Console.Clear();
        Console.WriteLine("Please select converting to: ");
        Console.WriteLine();
        for (int i = 0; i < (m2UnitList.Count); i++)
        {
            string unitName = m2UnitList[i];
            int index = (i + 1);
            Console.WriteLine($"{index}. {unitName}");

        }
       
        Console.Write("Enter your choice: ");
        string _userChoice = Console.ReadLine();
        int userChoice = int.Parse(_userChoice);
        return userChoice;
    }

    public void setFoot(double number)
    {
        _Foot = number;
    }

    public void setMeter(double number)
    {
        _Meter = number;
    }

    public void setKilometer(double number)
    {
        _Kilometer = number;
    }

    public void setMiles(double number)
    {
        _Miles = number;
    }

    public List<string> getList()
    {
        return m2UnitList;
    }

    public double ConvertfootTom()
    {
        return _Foot * 0.3048;
    }

    public double ConvertfootToKilometer()
    {
        return ((_Foot/3280.84)*1000);
    }

    public double ConvertfootTomiles()
    {
        return _Foot / 5280;
    }

    public double ConvertmTofoot()
    {
        return _Meter * 3.28084;
    }

    public double ConvertmtoKilometers()
    {
        return _Meter / 1000;
    }

    public double ConvertmToMiles()
    {
        return _Meter * 0.000621371;
    }

    public double ConvertKmTofoot()
    {
        return _Kilometer * 3280.84;
    }

    public double ConvertKmTom()
    {
        return _Kilometer * 1000;
    }

    public double ConvertKmToMi()
    {
        return _Kilometer * 0.621371;
    }

    public double ConvertmiTofoot()
    {
        return _Miles * 5280;
    }

    public double ConvertmiTom()
    {
        return _Miles * 1609.34;
    }

    public double ConvertmiToKm()
    {
        return _Miles * 1.60934;
    }



    
}