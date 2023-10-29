using System;
using System.Dynamic;
using System.Runtime.InteropServices;

class Reference
{
    //private string _reference;
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private int _lengthOfReference;
    private int _indexOfLastSpace;
    private int _indexOfColon;
    private int _indexOfDash;
    
    public Reference (string referenceIn) 
    /*A single constructor to handle single verse or multiple verse CONSECUTIVE 
    references (i.e. 1 Ne. 3:3, or 1 Ne. 3:10-12; but not like 1 Ne. 3:3, 10-12)*/
    {
        _lengthOfReference=referenceIn.Length;
        _indexOfLastSpace = referenceIn.LastIndexOf(" ");
        _book = referenceIn.Substring(0,_indexOfLastSpace);

        _indexOfColon = referenceIn.IndexOf(":");
        _chapter = int.Parse(referenceIn.Substring(_indexOfLastSpace+1,  _indexOfColon - _indexOfLastSpace-1));
        
        if (referenceIn.Contains("-"))
        {
            _indexOfDash = referenceIn.IndexOf("-");
            _endVerse = int.Parse(referenceIn.Substring(_indexOfDash+1, _lengthOfReference-(_indexOfDash+1)));
            _startVerse = int.Parse(referenceIn.Substring(_indexOfColon+1,_indexOfDash-(_indexOfColon+1)));
        }
        else
        {
            _startVerse = int.Parse(referenceIn.Substring(_indexOfColon+1,referenceIn.Length-(_indexOfColon+1)));
            _endVerse = _startVerse;
        }
    }

    public void DisplayReference()
    {
        if (_startVerse == _endVerse){
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
    }
}