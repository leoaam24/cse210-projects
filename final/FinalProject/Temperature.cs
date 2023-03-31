public class Temperature : Conversion
{
    private double _Celsius;
    private double _Fahrenheit;
    private double _Kelvin;

    List<string> tempUnitList = new List<string>();

    public Temperature() : base()
    {
        tempUnitList.Add("Celsius");
        tempUnitList.Add("Fahrenheit");
        tempUnitList.Add("Kelvin");
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
        for (int i = 0; i < tempUnitList.Count; i++)
        {
            string unitName = tempUnitList[i];
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
        tempUnitList.Remove(userPick);
        Console.Clear();
        Console.WriteLine("Please select converting to: ");
        Console.WriteLine();
        for (int i = 0; i < (tempUnitList.Count); i++)
        {
            string unitName = tempUnitList[i];
            int index = (i + 1);
            Console.WriteLine($"{index}. {unitName}");

        }
       
        Console.Write("Enter your choice: ");
        string _userChoice = Console.ReadLine();
        int userChoice = int.Parse(_userChoice);
        return userChoice;
    }


    public double ConvertCtoF(double Celsius)
    {
        return ((Celsius)*1.8) + 32;  
    }

    public double ConvertCtoK(double Celsius)
    {
        return ((Celsius) + 273.15);
    }

    public double ConvertFtoC(double Fahrenheit)
    {
        return ((Fahrenheit - 32)* 5/9);
    }

    public double ConvertFtoK(double Fahrenheit)
    {
        return (((Fahrenheit) + 459.67)*5/9);
    }

    public double ConvertKtoC(double Kelvin)
    {
        return (Kelvin - 273.15);
    }

    public double ConvertKtoF(double Kelvin)
    {
        double celsius = Kelvin - 273.15;
        return (celsius * 9/5) + 32;

    }

    public void SetCelsius(double input)
    {
        _Celsius = input;
    }

    public void SetFahrenheit(double input)
    {
        _Fahrenheit = input;
    }
    
    public void SetKelvin(double input)
    {
        _Kelvin = input;
    }

    public List<string> getList()
    {
        return tempUnitList;
    }



    
}