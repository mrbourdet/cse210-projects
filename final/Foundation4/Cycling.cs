using System;

public class Cycling :Activity
{
    private double _speedInKph;

    public Cycling(string activityType,string date, int lengthInMinutes, double speedInKph) :base(activityType, date, lengthInMinutes)
    {
        _speedInKph = speedInKph;
    }


    public void SetSpeedInKph(double speedInKph)
    {
        _speedInKph = speedInKph;
    }
    public double GetSpeedInKph()
    {
        return _speedInKph;
    } 
    
    public override double Distance()
    {
        return _speedInKph * (GetLengthInMinutes() / 60);
    }
    public override double Speed()
    {
        return _speedInKph;
    }
    public override double Pace()
    {
        return 60 / _speedInKph;
    }
}