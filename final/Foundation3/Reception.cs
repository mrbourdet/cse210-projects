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
    public new string GetAddress() 
    //added new modifier to get rid of compiler warning CS0108.  I don't fully understand the error.
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0108 
    // https://valeriosevilla.com/2018/01/02/some-polymorphism-csharp/
    {
        return $"{_address.GetVenueName()}\n{_address.GetStreetAddress()}\n{_address.GetCity()}, {_address.GetStateProvince()} {_address.GetPostalCode()}\n{_address.GetCountry()}";
    }
}