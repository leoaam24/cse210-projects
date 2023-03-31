public class Arithmetic : Calculation
{
    private int _userChoice;
    List<string> optionAvailable = new List<string>();

    public Arithmetic() : base()
    {
        optionAvailable.Add("Add");
        optionAvailable.Add("Subtract");
        optionAvailable.Add("Multiply");
        optionAvailable.Add("Divide");
        setUserChoice(CalculateList(optionAvailable));
    }

    public void DisplayResult(int selection, double answer)
    {
        if (selection == 1)
        {
            Console.WriteLine($"The Sum of the two numbers is: {answer}");
        }
        else if (selection == 2)
        {
            Console.WriteLine($"The difference of the two numbers is: {answer}");
        }
        else if (selection == 3)
        {
            Console.WriteLine($"The Product of the two numbers is {answer}");
        }
        else if (selection == 4)
        {
            Console.WriteLine($"The Quotient of the two numbers is: {answer}");
        }
        else
        {
            Console.WriteLine("Nothing to do here");
        }
        
        Console.Write("Please enter to continue...");
        Console.ReadLine();
    }


    

    public void setUserChoice(int data)
    {
        _userChoice = data;
    }

    public List<string> getOptionList()
    {
        return optionAvailable;
    }

    public int getUserChoice()
    {
        return _userChoice;
    }

   

}