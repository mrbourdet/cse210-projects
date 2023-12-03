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
}