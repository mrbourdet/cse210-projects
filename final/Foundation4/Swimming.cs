using System;

public class Swimming :Activity
{
    private int _laps;

    public Swimming(string activityType,string date, int lengthInMinutes, int laps) :base(activityType, date, lengthInMinutes)
    {
        _laps = laps;
    }


    public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000;
    }
    public override double Speed()
    {
        return (Distance() / GetLengthInMinutes()) * 60;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }
}