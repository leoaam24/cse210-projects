using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        int initiateCodes = 1;

        string activeEntry = "";
        string currentDateTime = "";


        while (initiateCodes == 1) {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select on e of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string strUserChoice = Console.ReadLine();

            int userChoice = int.Parse(strUserChoice);

            if (userChoice == 1) {
                Name systemDate = new Name();
                Console.Write("Current Date: ");
                systemDate.displayDateTime();
                Entry userInput = new Entry();
                Console.WriteLine();
                string activeDate = userInput._currentDate=systemDate.dateText;
                currentDateTime = activeDate;
                userInput.promptGenerator();
                Console.WriteLine();
                string userAnswer = Console.ReadLine();
                activeEntry = userAnswer;
                Console.WriteLine();
                Console.WriteLine("Your content for today is stored. Don't forget to save your progress.");
            }

            else if (userChoice == 2) {
                Journal displayJournal = new Journal();
                displayJournal.displayJournal();
            }

            else if (userChoice == 3) {
                Console.WriteLine("PlaceHolder");
            }

            else if (userChoice == 4) {
                Console.WriteLine("Do you want to save your current progress?");
                Console.Write("Yes / No? ");
                string saveUserChoice = Console.ReadLine();

                if(saveUserChoice == "Yes") {
                    Entry saveFile = new Entry();
                    saveFile.savetoFile(activeEntry, currentDateTime);
                }
            }

            else if (userChoice == 5) {
                initiateCodes = 0;
            }
        }


    }
}