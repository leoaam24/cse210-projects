using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();



        

        int startingNumber = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        double sumNumbers = 0;
        double listCount;
        int largestNumber = 0;
        int smallestNumber = 99999999;
        
        

        do
        {   
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            int convertToInt = int.Parse(userInput);

            if (!(convertToInt == 0)){
                startingNumber = convertToInt;
                numberList.Add(convertToInt);
                sumNumbers += convertToInt;
                if (convertToInt > largestNumber)
                {
                    largestNumber = convertToInt;
                }

                if (convertToInt < smallestNumber && convertToInt > 0)
                {
                    smallestNumber = convertToInt;
                }
            }
            else {
                startingNumber = 0;
            }


        } while (startingNumber != 0);

        listCount = numberList.Count;
        double listAverage = ((sumNumbers / listCount));

        numberList.Sort();
        

        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {listAverage}");
        Console.WriteLine($"The Largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
    }
}