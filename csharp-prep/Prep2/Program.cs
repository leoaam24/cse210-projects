using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;

        Console.Write("Please enter your Grade: ");
        string studentGrades = Console.ReadLine();

        

        float studentGrade = float.Parse(studentGrades);

        if (studentGrade >= 60 && studentGrade < 70) {letter = "D";}
        else if (studentGrade >= 70 && studentGrade < 80) {letter = "C";}
        else if (studentGrade >= 80 && studentGrade < 90) {letter = "B";}
        else if (studentGrade >= 90) {letter ="A";}
        else {letter = "F";}

        if ((studentGrade % 10) >= 7 && !(studentGrade !> 96) && !(studentGrade !< 60))
        {
            Console.WriteLine($"{letter}+");
        }

        else if((studentGrade % 10) < 3 && !(studentGrade !<60))
        {
            Console.WriteLine($"{letter}-");
        }

        else
        {
            Console.WriteLine(letter);
        }


        if (studentGrade > 70)
        {
            Console.WriteLine("You passed the class.");
        }

        else {
            Console.WriteLine("You failed please try again.");
        }

    }
}