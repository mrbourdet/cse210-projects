using System;

public class OutdoorGathering :Event 
{
    private string _weather;
    public OutdoorGathering(string eventType, string title, string description, string date, string time, Address address, string weather) 
        :base(eventType, title, description, date, time, address)
    {
        _weather = weather;
    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public void DisplayFullOutdoorGatheringMessage()
    {
        Console.WriteLine("Full ----------------------------------------------------------------------------");
        Console.WriteLine($"Title:\t\t{_title}\nDescription:\t{_description}\nDate & Time:\t{_date} at {_time}\nLocation:\n{this.GetAddress()}\n\nWeather Statement:\t{_weather}\n");
    }
}