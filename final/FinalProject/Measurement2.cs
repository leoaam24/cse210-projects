public class Measurement2 : Conversion
{
    private double _foot;
    private double _meter;
    private double _kiloMeter;
    private double _miles;

    List<string> m2UnitList = new List<string>();

    public Measurement2() : base()
    {
        m2UnitList.Add("Foot");
        m2UnitList.Add("Meter");
        m2UnitList.Add("Kilometer");
        m2UnitList.Add("Miles");

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
        _foot = number;
    }

    public void setMeter(double number)
    {
        _meter = number;
    }

    public void setKilometer(double number)
    {
        _kiloMeter = number;
    }

    public void setMiles(double number)
    {
        _miles = number;
    }

    public List<string> getList()
    {
        return m2UnitList;
    }

    public double ConvertFootToM(double Foot)
    {
        return Foot * 0.3048;
    }

    public double ConvertFootToKilometer(double Foot)
    {
        return ((Foot/3280.84));
    }

    public double ConvertFootToMiles(double Foot)
    {
        return Foot / 5280;
    }

    public double ConvertMToFoot(double Meter)
    {
        return Meter * 3.28084;
    }

    public double ConvertMToKilometers(double Meter)
    {
        return Meter / 1000;
    }

    public double ConvertMToMiles(double Meter)
    {
        return Meter * 0.000621371;
    }

    public double ConvertKmToFoot(double Kilometer)
    {
        return Kilometer * 3280.84;
    }

    public double ConvertKmToM(double Kilometer)
    {
        return Kilometer * 1000;
    }

    public double ConvertKmToMi(double Kilometer)
    {
        return Kilometer * 0.621371;
    }

    public double ConvertMiToFoot(double Miles)
    {
        return Miles * 5280;
    }

    public double ConvertMiToM(double Miles)
    {
        return Miles * 1609.34;
    }

    public double ConvertMiToKm(double Miles)
    {
        return Miles * 1.60934;
    }



    
}