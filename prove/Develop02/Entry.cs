using System.IO;
using System.Collections.Generic;

public class Entry 
{
    public static string _fileName = "";


    public string _currentDate = "";

    public List<string> journalEntries = new List<string>();


    
    static string [] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"   
    };


    public static List<string> _promptList = new List<string>(prompts);

    public List<Entry> _entryStorage = new List<Entry>();

    static Random random = new Random();
    

    public Entry()
    {
    }

    
    public string promptGenerator()
    {
        int index = random.Next(_promptList.Count);
        return (_promptList[index]);
    }

    public void savetoFile(List<string> storeCurrentEntry)
    {
        using (StreamWriter outputfile = new StreamWriter(_fileName, true))
        {
            string date = storeCurrentEntry[0];
            string promptQuestion = storeCurrentEntry[1];
            string userEntry = storeCurrentEntry[2];
            outputfile.WriteLine(date);
            outputfile.WriteLine(promptQuestion);
            outputfile.WriteLine(userEntry);
            outputfile.WriteLine();
            journalEntries.Add(_fileName);
            

        }

         using (StreamWriter outputfile = new StreamWriter("allentry.csv", true))
        {
            string date = storeCurrentEntry[0];
            string promptQuestion = storeCurrentEntry[1];
            string userEntry = storeCurrentEntry[2];
            outputfile.WriteLine(date);
            outputfile.WriteLine(promptQuestion);
            outputfile.WriteLine(userEntry);
            outputfile.WriteLine();
            

        }
    }

}


