using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        

        string startGuess = "no";
        do {
            int number = randomGenerator.Next(1, 101);
            Console.Write("Do you want to start Guessing?(yes/no) ");
            startGuess = Console.ReadLine();
            string statusGuess;
            if (startGuess == "yes") 
            {
                statusGuess = "continue";
            }
            else {
                statusGuess = "stop";
            }
                while (statusGuess == "continue")
                    {

                    int numberTries = 0;

                        do
                        {
                            Console.Write("What is your guess? ");
                            string _guessNumber = Console.ReadLine();

                            int guessNumber = int.Parse(_guessNumber);

                            if (guessNumber > number) 
                            {
                                Console.WriteLine("Lower");
                                statusGuess = "continue";
                                numberTries += 1;

                            }
                    
                            else if (guessNumber < number)
                            {
                                Console.WriteLine("Higher");
                                statusGuess = "continue";
                                numberTries += 1;
                            }
                            else 
                            {   
                                numberTries += 1;
                                Console.WriteLine("You guessed it!");
                                Console.WriteLine($"You've Guessed it {numberTries} time/s.");
                                statusGuess = "stop";
                                startGuess = "yes";

                            }
                        } while (statusGuess == "continue");
                    }
            } while (startGuess == "yes");
        if (startGuess ==  "no")
    {
        Console.WriteLine("Comeback when you're ready.");
    }
    }   
    
}