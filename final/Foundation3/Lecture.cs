using System;

public class Lecture :Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string eventType, string title, string description, string date, string time, Address address, string speaker, int capacity) 
        : base(eventType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void DisplayFullLectureMessage()
    {
        Console.WriteLine("Full ----------------------------------------------------------------------------");
        Console.WriteLine($"Title:\t\t{_title}\nDescription:\t{_description}\nDate & Time:\t{_date} at {_time}\nLocation:\n{this.GetAddress()}\n\nThe speaker will be: {_speaker}\nSeating is limited to {_capacity} attendees.\n\n");
    }
}