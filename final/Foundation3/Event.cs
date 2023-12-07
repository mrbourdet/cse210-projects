using System;

public class Event 
{
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description; 
        _date = date; 
        _time = time; 
        _address = address;
    }
    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }
    public string GetEventType()
    {
        return _eventType;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetAddress(Address address)
    {
       _address = address; 
    }
    public string GetAddress()
    {
        return $"\t\t{_address.GetVenueName()}\n\t\t{_address.GetStreetAddress()}\n\t\t{_address.GetCity()}, {_address.GetStateProvince()} {_address.GetPostalCode()}\n\t\t{_address.GetCountry()}";
    } 
    public void DisplayStandardMessage()
    {
        Console.WriteLine("Standard ------------------------------------------------------------------------");
        Console.WriteLine($"Title:\t\t{_title}\nDescription:\t{_description}\nDate & Time:\t{_date} at {_time}\nLocation:\n{this.GetAddress()}\n");
    }
    public void DisplayShortMessage()
    {
        Console.WriteLine("Short ---------------------------------------------------------------------------");
        Console.WriteLine($"Event Type:\t{_eventType}\nTitle:\t\t{_title}\nDate:\t\t{_date}\n");
    }
}