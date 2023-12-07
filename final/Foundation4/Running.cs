using System;

public class Running :Activity
{
    private double _distanceInKm;

    public Running(string activityType, string date, int lengthInMinutes, double distanceInKm) :base(activityType, date, lengthInMinutes)
    {
        _distanceInKm = distanceInKm;
    }

    
    public void SetDistance(double distanceInKm)
    {
        _distanceInKm = distanceInKm;
    }
    public double GetDistanceInKm()
    {
        return _distanceInKm;
    }
    public override double Distance()
    {
        return _distanceInKm;
    }
    public override double Speed()
    {
        return (_distanceInKm / GetLengthInMinutes()) * 60;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }
}