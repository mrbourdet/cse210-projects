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
        SetWelcomeString("breathing");
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _activityDuration = -1;

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
    GetReadyToStart();
    this.sw.Start();
    double acc = 0.0;
    while (acc <= _activityDuration)
    {
        acc += deltaTime();
        Console.Write("Breathe In...");
        CountdownTimer(4);
        Console.WriteLine();
        Console.Write("Breathe 0ut...");
        CountdownTimer(5);
        Console.WriteLine();
    }
    WellDone();
    EndMessage();

}
    

}