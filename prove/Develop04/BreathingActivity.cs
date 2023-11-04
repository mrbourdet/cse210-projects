using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

//"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
//"Breathe in..."
//"Breathe out..."

public class BreathingActivity : Activity
{

public BreathingActivity() :base()
    {
        SetActivityName("breathing");
        SetWelcomeString();
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.\n";
    }
public void Breathing()
{
    // List<string> breathingPrompts = new List<string>();
    // breathingPrompts.Add("Breathe in...");
    // breathingPrompts.Add("Breathe out...");

    Console.Clear();
    Console.WriteLine(_welcomeString);
    Console.WriteLine(_activityDescription);
    _activityDuration = GetSessionDuration();
    Console.WriteLine($"Activity Duration = {_activityDuration}");
    GetReadyToStart();
    DateTime StartTime = DateTime.Now;
    DateTime EndTime = StartTime.AddSeconds(_activityDuration);

    do
    {
        Console.Write("Breathe In...");
        CountdownTimer(4);
        Console.WriteLine();
        Console.Write("Breathe 0ut...");
        CountdownTimer(4);
        Console.WriteLine();
    } while (DateTime.Now < EndTime);
    WellDone();
    EndMessage();

}
    

}