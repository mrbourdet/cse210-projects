using System;
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_company} {_jobTitle} {_startYear}-{_endYear}");
    }
}