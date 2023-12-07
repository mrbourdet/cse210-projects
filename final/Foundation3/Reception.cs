using System;

public class Reception :Event
{
    private string _emailRSVP;
    public Reception(string eventType, string title, string description, string date, string time, Address address, string emailRSVP) 
        : base(eventType, title, description, date, time, address)
    {
        _emailRSVP = emailRSVP;
    }

    public void SetEmailRSVP(string emailRSVP)
    {
        _emailRSVP = emailRSVP;
    }
    public string GetEmailRSVP()
    {
        return _emailRSVP;
    }
    
    public void DisplayFullReceptionMessage()
    {
        Console.WriteLine("Full  ---------------------------------------------------------------------------");
        Console.WriteLine($"Title:\t\t{_title}\nDescription:\t{_description}\nDate & Time:\t{_date} at {_time}\nLocation:\n{this.GetAddress()}\n\nToRSVP, send response to: {_emailRSVP}\n");
    }
}