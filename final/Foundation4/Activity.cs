using System;

public abstract class Activity
{
    protected string _activityType;
    protected string _date;
    protected int _lengthInMinutes;

    public Activity (string activityType,string date, int lengthInMinutes)
    {
        _activityType = activityType;
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public void SetActivityType(string activityType)
    {
        _activityType = activityType;
    }
    public string GetActivityType()
    {
        return _activityType;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetLengthInMinutes (int lengthInMinutes)
    {
        _lengthInMinutes = lengthInMinutes;
    }
    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract double Distance();
    public abstract double Speed();
    public double Pace() // min per km
    {
        return 60 / Speed();
    }
    public string Summary()
    {
        return $"{_date} {_activityType} ({_lengthInMinutes} min): Distance {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
}