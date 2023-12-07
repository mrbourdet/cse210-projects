using System;

public class Cycling :Activity
{
    private double _speedInKph;

    public Cycling(string activityType, string date, int lengthInMinutes, double speedInKph) :base(activityType, date, lengthInMinutes)
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
    
    public override double Distance() //km
    {
        return _speedInKph * (GetLengthInMinutes() / 60);
    }
    public override double Speed() //kph
    {
        return _speedInKph;
    }
    public override double Pace() // min per km
    {
        return 60 / _speedInKph;
    }
}