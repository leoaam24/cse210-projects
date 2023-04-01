public class Measurement1 : Conversion
{
    private double _inch;
    private double _centiMeter;
    private double _milliMeter;

    List<string> m1UnitList = new List<string>();

    public Measurement1() : base()
    {
        m1UnitList.Add("Inch");
        m1UnitList.Add("Centimeter");
        m1UnitList.Add("Millimeter");
    }


    public override int conversionFrom()
    {
        Console.Clear();
        Console.WriteLine("Please select converting from: ");
        Console.WriteLine();
        for (int i = 0; i < m1UnitList.Count; i++)
        {
            string unitName = m1UnitList[i];
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
        m1UnitList.Remove(userPick);
        Console.Clear();
        Console.WriteLine("Please select converting to: ");
        Console.WriteLine();
        for (int i = 0; i < (m1UnitList.Count); i++)
        {
            string unitName = m1UnitList[i];
            int index = (i + 1);
            Console.WriteLine($"{index}. {unitName}");

        }
       
        Console.Write("Enter your choice: ");
        string _userChoice = Console.ReadLine();
        int userChoice = int.Parse(_userChoice);
        return userChoice;
    }

    public void setInches(double number)
    {
        _inch = number;
    }

    public void setCentimeter(double number)
    {
        _centiMeter = number;
    }

    public void setMillimeter(double number)
    {
        _milliMeter = number;
    }

    public List<string> getList()
    {
        return m1UnitList;
    }

    public double ConvertInchTocm(double Inch)
    {
        return Inch * 2.54;
    }

    public double ConvertCmToInch(double Centimeter)
    {
        return Centimeter * 0.393701;
    }

    public double ConvertCmToMm(double Centimeter)
    {
        return Centimeter * 10;
    }

    public double ConvertMmToCm(double Millimeter)
    {
        return Millimeter / 10;
    }

    public double ConvertInchToMm(double Inch)
    {
        return Inch * 25.4;
    }

    public double ConvertMmToInch(double Millimeter)
    {
        return Millimeter / 25.4;
    }


    
}