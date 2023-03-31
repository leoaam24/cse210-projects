public abstract class Calculation
{
    private double _number1;
    private double _number2;


    public int CalculateList(List<string> optionsAvailable)
    {
        Console.WriteLine("What do you want to do? ");
        Console.WriteLine();
        for (int i = 0; i < optionsAvailable.Count; i++)
        {
            string unitName = optionsAvailable[i];
            int index = (i + 1);
            Console.WriteLine($"{index}. {unitName}");
        }
        Console.WriteLine();
        Console.Write("Enter your choice: ");
        string _userChoice = Console.ReadLine();
        int userChoice = int.Parse(_userChoice);
        return userChoice;
    }

    public void CalculatePrompt()
    {
        Console.Clear();
        Console.Write("Please input the first number: ");
        string _n1 = Console.ReadLine();
        _number1 = double.Parse(_n1);
        Console.Write("Please input the second number: ");
        string _n2 = Console.ReadLine();
        _number2 = double.Parse(_n2);

    }

    public double Calculate(int selection)
    {
        CalculatePrompt();
        double n1 = _number1;
        double  n2 = _number2;
        double answer = 0;
        if (selection == 1)
        {
            answer =  n1 + n2;
        }
        else if (selection == 2)
        {
            answer =  n1 - n2;
        }
        else if (selection == 3)
        {
            answer = n1 * n2;
        }
        else if (selection == 4)
        {
            answer = n1 / n2;
        }
        return answer;
    }

    public void setNumbers(double data1, double data2)
    {  
        _number1 = data1;
        _number2 = data2;
    }

    public double getNumber1()
    {
        return _number1;
    }

    public double getNumber2()
    {
        return _number2;
    }

    

    
}