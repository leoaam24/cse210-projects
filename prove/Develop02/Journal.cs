public class Journal
{
    public static string  _fileName = "myFile.txt";

    string[] lines = System.IO.File.ReadAllLines(_fileName);

    public Journal()
    {
    }

    public void displayJournal()
    {
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        } 

    }
}