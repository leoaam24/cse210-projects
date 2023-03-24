public abstract class Conversion
{
    public abstract void Convert();

    public abstract int conversionFrom();

    public abstract int conversionTo(string userPick);

    public virtual double fromEntry(string userPick)
    {
        Console.Write($"{userPick}: ");
        string _userInput = Console.ReadLine();
        double userInput = double.Parse(_userInput);
        return userInput;
    }

    public virtual void toEntry(string userPick, double result)
    {
        Console.WriteLine($"{userPick}: {result}");
        Console.Write("Please enter to continue...");
        Console.ReadLine();
    }

}

