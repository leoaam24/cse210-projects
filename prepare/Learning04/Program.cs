using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment();
        Console.WriteLine(student1.Getsummary());

        Assignment student2 = new Assignment("Andrew Miller", "Math");
        Console.WriteLine(student2.Getsummary());

        MathAssignment student3 = new MathAssignment();
        student3.GetHomeworkList();

        MathAssignment student4 = new MathAssignment("Robert Rodriguez","Fractions","Section 7.3","Problems 8-19");
        student4.GetHomeworkList();

        WritingAssignment student5 = new WritingAssignment();
        student5.GetWritingInfo();

        WritingAssignment student6 = new WritingAssignment("Mary Waters","European History","The cause of World War II by Mary Waters");
        student6.GetWritingInfo();

    }
}