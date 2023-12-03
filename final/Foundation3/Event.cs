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
        return $"{_address.GetVenueName()}\n{_address.GetStreetAddress()}\n{_address.GetCity()}, {_address.GetStateProvince()} {_address.GetPostalCode()}\n{_address.GetCountry()}";
    } 
}