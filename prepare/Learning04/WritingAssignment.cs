public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment()
    {
        _title = "Your title should be here";
    }

    public WritingAssignment(string studentname, string topic,string title) : base(studentname, topic)
    {
        _title = title;
    }

    public string getTitle()
    {
        return _title;
    }

    public void setTitle(string title)
    {
        _title = title;
    }

    public void GetWritingInfo()
    {
        Console.WriteLine($"{getStudentName()} - {getTopic()}");
        Console.WriteLine($"{_title}");
    }


}