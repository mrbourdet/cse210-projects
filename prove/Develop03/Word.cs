using System;
using System.Net.Security;

public class Word
{
    private string _word;
    private bool _hidden;
    
    public Word ()
    {
        _word = "";
    }
    public Word (string word)
    {
        _word = word;
        _hidden = false;

    }
    public string HideWord(string input)
    {
        // Replace each character with an underscore
        string result = new string('_', input.Length);
        _hidden = true;
        return result;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void DisplayWord()
        {
            Console.WriteLine(_word);
        }
}


