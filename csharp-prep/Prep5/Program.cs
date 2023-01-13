using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName ()
        {
            Console.Write("PLease enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            string _userNumber = Console.ReadLine();
            int userNumber = int.Parse(_userNumber);
            return userNumber;
        }

        static int SquareNumber (int userNumber)
        {
            int squaredNumber = userNumber * userNumber;
            return squaredNumber;
        }

        static void DisplayResult (string userName_, int userNumberSquared)
        {
            Console.WriteLine($"{userName_}, the square of your number is {userNumberSquared}");
        }

        

    }

}