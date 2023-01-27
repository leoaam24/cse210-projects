public class Name
{
    public string _userName = "";

    public static DateTime currentDateTime = DateTime.Now;
    public string _dateText = currentDateTime.ToShortDateString();

    public string _dateDayYear = currentDateTime.ToString("dddd, dd MMMM yyyy");
    public string _dateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
    

    public Name()
    {
    }

    public void userNameInput()
    {
        Console.WriteLine(_userName);
    }

    public void displayDateTime()
    {
       Console.WriteLine(currentDateTime);
    }




}

