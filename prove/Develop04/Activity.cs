using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Diagnostics;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;
    protected string _welcomeString;
    protected DateTime _startTime;

    public Activity ()
    {
        _activityName = "";
        _activityDescription = "";
        _activityDuration = 10;
        _welcomeString = "";
        _startTime = DateTime.Now;
    }
  

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityDecription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public void SetWelcomeString(string activityName)
    {
        _welcomeString = $"Welcome to the {activityName} Activity";
    }
    public string GetWelcomeString()
    {
        return _welcomeString;
    }
    public int GetSessionDuration()
    {
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        int input = Int32.Parse(Console.ReadLine());
        return input;
    }
    public void CountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DotsTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
        public void Spinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    protected Stopwatch sw = new Stopwatch();
    protected double lastFrame;
    public double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        this.lastFrame = ts.TotalMilliseconds;
        return dt;
    }
    public void GetReadyToStart ()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(8);
        Console.WriteLine();
    }
    public void WellDone()
    {
        Console.WriteLine("Well done!!");
        Spinner(5);
    }
    public void EndMessage()
    {
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} activity.");
        Spinner(5);
    }
}