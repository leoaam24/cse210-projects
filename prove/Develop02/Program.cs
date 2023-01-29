using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int initiateCodes = 1;

        string activeEntry = "";
        string currentDateTime = "";

        List<string> storeCurrentEntry = new List<string>();

        Name systemDate = new Name();
        Entry userInput = new Entry();
        

        while (initiateCodes == 1) 
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string strUserChoice = Console.ReadLine(); 
            int userChoice = int.Parse(strUserChoice);
            Console.WriteLine("");


            if (userChoice == 1) {
                storeCurrentEntry.Clear();
                // Display and assign Current Date
                Console.Write("Current Date: ");
                systemDate.displayDateTime();
                Console.WriteLine("");
                string activeDate = systemDate._dateTime;
                storeCurrentEntry.Add(activeDate);
                currentDateTime = activeDate; //

                //Display generated prompt question and answer
                string promptQuestion = userInput.promptGenerator();
                storeCurrentEntry.Add(promptQuestion);
                Console.WriteLine(promptQuestion);
                Console.WriteLine("");
                string userAnswer = Console.ReadLine();
                storeCurrentEntry.Add(userAnswer);
                activeEntry = userAnswer; //

                // Automatically Saves a file to a "myFile.txt" if it doesn't exist the first time the loads.
                // if (!File.Exists("myFile.txt"))
                // {   
                //     Entry._fileName = "myFile.txt";
                //     userInput.savetoFile(storeCurrentEntry);
                //     Journal._getFileName = "myFile.txt";
                // }
                //Notify user to save progress
                Console.WriteLine("");
                Console.WriteLine("Please don't forget to save your progress");//
            }

            else if (userChoice == 2) {
                Journal displayJournal = new Journal();
                displayJournal.displayJournal();
            }

            else if (userChoice == 3) {
                Console.WriteLine("You can choose from these saved files: ");
                Console.WriteLine("");
                if ((userInput.journalEntries.Any())) {
                    foreach (string journal in userInput.journalEntries) {
                    Console.WriteLine(journal);
                    Console.WriteLine("");
                    }
                } else {
                    Console.WriteLine("Your Journal is still empty");
                    break;
                }
                Console.Write("Please select the file: ");
                string userChoiceLoad = Console.ReadLine();
                Journal._getFileNameForLoading = userChoiceLoad;
                Journal displayLoad = new Journal();
                displayLoad.displayJournalLoading();

            }

            else if (userChoice == 4) {
                //Notify User for saving
                Console.WriteLine("Do you want to save your current progress?");
                Console.Write("Yes / No? ");
                string _userSaveChoice_ = Console.ReadLine(); 
                string userSaveChoice = _userSaveChoice_.ToLower();//
                Console.WriteLine("");

                if (userSaveChoice == "yes") 
                {
                    //Notify user if wanted to make filename as current Date Time or Custom
                    Console.WriteLine("Do you want the current Date and Time to be the file name? ");
                    Console.Write("Yes / No? ");
                    string _userFileNameDefine_ = Console.ReadLine();
                    string userFileNameDefine = _userFileNameDefine_.ToLower();

                    if (userFileNameDefine == "yes")
                    {
                        Entry._fileName = systemDate._dateDayYear;
                        userInput.savetoFile(storeCurrentEntry);
                    } 
                    else if (userFileNameDefine == "no")
                    {
                        Console.Write("What is your preferred filename? ");
                        string preferredFileName = Console.ReadLine();
                        Entry._fileName = preferredFileName;
                        userInput.savetoFile(storeCurrentEntry);
                    }
                }
                

            }
            
            else if (userChoice == 5) {
            initiateCodes = 0;
            }
        }
    }
}

