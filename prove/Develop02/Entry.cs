using System;

public class Entry
{
    public string _userEntry;
    public string _dateEntry;
    public string _promptEntry;
    public void Display()
    {
        Console.WriteLine($"{_dateEntry}, {_promptEntry}, {_userEntry}");
    }
}