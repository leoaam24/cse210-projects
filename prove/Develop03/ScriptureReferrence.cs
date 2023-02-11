public class ScriptureReferrence
{
    private string _scripture = "";

    private string _scriptureReferrenceText = "";

    public ScriptureReferrence()
    {
        _scripture = "Matthew 5:22";
        _scriptureReferrenceText = "But I say unto you, That whosoever is angry with his brother without a cause shall be in danger of the judgment: and whosoever shall say to his brother, Raca, shall be in danger of the council: but whosoever shall say, Thou fool, shall be in danger of hell fire.";
    }

    public ScriptureReferrence(string referrence)
    {
        _scripture = referrence;
    }

    public string getSR(){
        return _scripture;
    }

    public string getSRText(){
        return _scriptureReferrenceText;
    }

}