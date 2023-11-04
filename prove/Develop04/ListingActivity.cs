using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

public class ListingActivity :Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        " --- Who are people that you appreciate?. ---\n",
        " --- What are personal strengths of yours? ---\n",
        " --- Who are people that you have helped this week? ---\n",
        " --- When have you felt the Holy Ghost this month? ---\n",
        " --- Who are some of your personal heroes? ---\n"
    };
    private int _randomListingIndex; 
    private Stopwatch _sw = new Stopwatch();
    private double _lastFrame;
    public ListingActivity() :base()
        {
            SetActivityName("listing");
            SetWelcomeString();
            _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
            _activityDuration = -1;
        }
    public string GetRandomListingPrompt()
    {
        Random rand = new Random();
        _randomListingIndex = rand.Next(0, _listingPrompts.Count);
        return _listingPrompts[_randomListingIndex];
    }
    public double deltaTime()
    {
        TimeSpan ts = _sw.Elapsed;
        double firstFrame = ts.TotalSeconds;
        double dt = firstFrame - _lastFrame;
        _lastFrame = ts.TotalSeconds;
        return dt;
    }
    public void Listing()
    {
        Console.Clear();
        Console.WriteLine(_welcomeString);
        Console.WriteLine(_activityDescription);
        _activityDuration = GetSessionDuration();
        GetReadyToStart();//5 second pause
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine(GetRandomListingPrompt());
        Console.WriteLine("You may begin in: ");
        CountdownTimer(5);

        _sw.Start(); //Timer starts
        
        double acc = 0.0;
        int lineCount = 0;
        List<string> buf = new List<string>();
        Console.Write("> ");
        while (acc <= _activityDuration)
        {
            acc += this.deltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                buf.Add("\n");
                lineCount++;
                Console.Write("> ");

            }
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
        } 
        Console.WriteLine($"You've listed {lineCount} items!");
        WellDone();
        EndMessage();

    }
}