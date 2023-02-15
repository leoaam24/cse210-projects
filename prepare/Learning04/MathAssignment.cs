public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment() : base()
    {
        _textbookSection = "Your textbookSection should be here";
        _problems = "The problem should be here";
    }

    public MathAssignment(string name, string topic ,string section, string problem) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problem;
    }

    public string gettextbookSection()
    {
        return _textbookSection;
    }

    public string getProblems()
    {
        return _problems;
    }

    public void setTextbookSection(string textbooksection)
    {
        _textbookSection = textbooksection;
    }

    public void setProblems(string problem)
    {
        _problems = problem;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"{getStudentName()} - {getTopic()}");
        Console.WriteLine($"{_textbookSection} - {_problems}");
    }
}