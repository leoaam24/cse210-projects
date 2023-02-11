using System;

class Program
{
    static void Main(string[] args)
    {
        
        ScriptureReferrence SR = new ScriptureReferrence();
        ScriptureText ST = new ScriptureText();
        HideWords HW = new HideWords(ST.getScriptureList());
        string UserInput = "start";
        // string selectedScripture = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";
        // ST.setScriptureText(selectedScripture);
        ST.setScriptureText(SR.getSRText());
        Console.Write($"{SR.getSR()}");
        ST.displayScriptureText();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        UserInput = Console.ReadLine();
        HW.createStoredIndexList();
        int loopStopIndicator = HW.stopLoop();
        while (UserInput != "quit")
        { 
            Console.Clear();
            Console.Write($"{SR.getSR()}");
            HW.replaceWords();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            UserInput = Console.ReadLine();
            loopStopIndicator = HW.stopLoop();
            if (loopStopIndicator == 1)
            {
                UserInput = "quit";
            }

        }

    }
}