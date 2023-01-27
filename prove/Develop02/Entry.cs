using System.IO;
using System.Collections.Generic;

public class Entry 
{
    public string _fileName = "myFile.txt";


    public string _currentDate = "";

    static string [] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"   
    };


    public static List<string> _promptList = new List<string>(prompts);

    static Random random = new Random();
    static int index = random.Next(_promptList.Count);

    public Entry()
    {
    }

    
    public void promptGenerator()
    {
        Console.WriteLine(_promptList[index]);
    }

    public void savetoFile(string activeEntry, string activeDate)
    {
        using (StreamWriter outputfile = new StreamWriter(_fileName))
        {
            outputfile.WriteLine($"Date: {activeDate}");
            outputfile.WriteLine(_promptList[index]);
            outputfile.WriteLine(activeEntry);
        }
    }

    
    

}


