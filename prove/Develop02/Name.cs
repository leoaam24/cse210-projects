public class Name
{
    public string _userName = "";

    static DateTime currentDateTime = DateTime.Now;
    public string dateText = currentDateTime.ToShortDateString();

    public Name()
    {
    }

    public void userNameInput()
    {
        Console.WriteLine(_userName);
    }

    public void displayDateTime()
    {
       Console.WriteLine(dateText);
    }




}

