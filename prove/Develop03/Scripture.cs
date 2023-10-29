using System;

public class Scripture
{
    private string _scripture;
    private string[] _arrScripture;
    //private string[] _arrHiddenScripture;
    private int _randomIndex;
    private bool[] _arrIsHidden;
    private int _length;

    public Scripture (string scripture)
    {
        _scripture = scripture;
        _arrScripture = scripture.Split('\n',' ');//Split the scripture at spaces and at verse ends.
        _length = _arrScripture.Length;
        _arrIsHidden = new bool[_length]; //Initialize _arrIsHidden array to false
    
    }
    public void Hide3Random()
    {
        for (int i=0;i<3;i++)
        {
            Word w = new Word();
            do 
            {
                Random random = new Random(); //Initialize random
                _randomIndex = random.Next(0, _arrScripture.Length); //Choose random int between 0 and length of scripture                
            } while (_arrIsHidden[_randomIndex]);
            _arrIsHidden[_randomIndex] = true; //Mark the index tracker as hidden
            _arrScripture[_randomIndex] = w.HideWord(_arrScripture[_randomIndex]); //Hide the word
            
            if (w.IsHidden())
            {
                break;
            }
        }
    }
    public void DisplayScripture()
    {
        Console.WriteLine($"\n{_scripture}");
    }
    public void DisplayHiddenScripture()
    {
        Console.WriteLine($"\n{string.Join(" ", _arrScripture)}");
    } 
    public bool AllWordsHidden ()
    {
        return !_arrIsHidden.Contains(false);
    }
}