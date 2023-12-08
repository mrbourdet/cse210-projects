using System;

public class Swimming :Activity
{
    private double _laps;

    public Swimming(string activityType, string date, int lengthInMinutes, double laps) :base(activityType, date, lengthInMinutes)
    {
        _laps = laps;
    }


    public void SetLaps(double laps)
    {
        _laps = laps;
    }
    public double GetLaps()
    {
        return _laps;
    }

    public override double Distance() //km
    {
        return _laps * 50 / 1000;
    }
    public override double Speed() //kph
    {
        return Distance() / GetLengthInMinutes() * 60;
    }
}