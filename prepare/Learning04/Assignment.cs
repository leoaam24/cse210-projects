public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment()
    {
        _studentName = "Your Student Name should be here";
        _topic = "Your topic should be here";
    }

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string getStudentName()
    {
        return _studentName;
    }

    public string getTopic()
    {
        return _topic;
    }

    public void setStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public void setTopic(string topic)
    {
        _topic = topic;
    }

    public string Getsummary()
    {
        return $"{_studentName} - {_topic}";
    }

}