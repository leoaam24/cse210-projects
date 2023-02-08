public class ScriptureReferrence
{
    private string _scripture = "";

    public ScriptureReferrence()
    {
    }

    public ScriptureReferrence(string referrence)
    {
        _scripture = referrence;
    }

    public string getSR(){
        return _scripture;
    }

}