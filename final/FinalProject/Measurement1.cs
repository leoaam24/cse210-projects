public class Measurement1 : Conversion
{
    private double _Inch;
    private double _Centimeter;
    private double _Millimeter;

    List<string> m1UnitList = new List<string>();

    public Measurement1() : base()
    {
        m1UnitList.Add("Inch");
        m1UnitList.Add("Centimeter");
        m1UnitList.Add("Millimeter");
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
        _Inch = number;
    }

    public void setCentimeter(double number)
    {
        _Centimeter = number;
    }

    public void setMillimeter(double number)
    {
        _Millimeter = number;
    }

    public List<string> getList()
    {
        return m1UnitList;
    }

    public double ConvertInchTocm(double Inch)
    {
        return Inch * 2.54;
    }

    public double ConvertcmToInch(double Centimeter)
    {
        return Centimeter * 0.393701;
    }

    public double ConvercmTomm(double Centimeter)
    {
        return Centimeter * 10;
    }

    public double ConvertmmTocm(double Millimeter)
    {
        return Millimeter / 10;
    }

    public double ConvertInchTomm(double Inch)
    {
        return Inch * 25.4;
    }

    public double ConvertmmToInch(double Millimeter)
    {
        return Millimeter / 25.4;
    }


    
}