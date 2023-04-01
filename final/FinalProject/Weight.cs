public class Weight : Conversion
{
    private double _milliGram;
    private double _gram;
    private double _kiloGram;
    private double _pounds;


    List<string> WUnitList = new List<string>();

    public Weight() : base()
    {
        WUnitList.Add("Milligrams");
        WUnitList.Add("Grams");
        WUnitList.Add("Kilograms");
        WUnitList.Add("Pounds");


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
        _milliGram = number;
    }
    public void setGram(double number)
    {
        _gram = number;
    }

    public void setKiloGram(double number)
    {
        _kiloGram = number;
    }

    public void setPounds(double number)
    {
        _pounds = number;
    }

    

    public List<string> getList()
    {
        return WUnitList;
    }

    public double ConvertMgToG(double MilliGram)
    {
        return MilliGram / 1000;
    }

    public double ConvertMgToKg(double MilliGram)
    {
        return MilliGram / 1000000;
    }

    public double ConvertMgToLb(double MilliGram)
    {
        return (MilliGram/1000) * 0.00220462;
    }

    public double ConvertGToMg(double Gram)
    {
        return Gram * 1000;
    }

    public double ConvertGtoKg(double Gram)
    {
        return Gram / 1000;
    }

    public double ConvertGToLb(double Gram)
    {
        return Gram / 453.59237;
    }  
    public double ConvertKgToMg(double Kilogram)
    {
        return Kilogram * 1000000;
    }
    
    public double ConvertKgToG(double Kilogram)
    {
        return Kilogram * 1000;
    }
    public double ConvertKgToLb(double Kilogram)
    {
        return Kilogram * 2.20462;
    }

    public double ConvertLbToMg(double Pounds)
    {
        return Pounds * 453.59237 * 1000;
    }

    public double ConvertLbToG(double Pounds)
    {
        return Pounds * 453.59237;
    }

    public double ConvertLbToKg(double Pounds)
    {
        return Pounds * 0.45359237;
    }



    
}