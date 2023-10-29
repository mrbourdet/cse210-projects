using System;
using System.Globalization;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private string _welcomeString;

    private void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    private string GetActivityName()
    {
        return _activityName
    }
    private void SetActivityDecription(string activityDescription)
    {
        _activityName = activityDescription;
    }

    private void DisplayWelcomeString(string activityType)
    {
        Console.WriteLine($"Welcome to the {activityType} Activity.");
    }
    private int GetSessionDuration()
    {
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        int input = Int32.Parse(Console.ReadLine());
        return input;
        }
    }

}