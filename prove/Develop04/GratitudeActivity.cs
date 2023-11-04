using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

public class GratitudeActivity :Activity
{
    private List<string> _gratitudePrompts = new List<string>
    {   //Gratitude prompts taken (with gratitude) from:
        //https://awbw.org/programs/windows-of-gratitude-workshop-series/
        " --- What does it mean to you to look at your life through a lens of gratitude? ---\n",
        " --- List five things you're grateful for that your senses allow you to experience. ---\n",
        " --- Think about the beauty of ordinary moments you appreciate in life. Describe how they keep you grounded. ---\n",
        " --- We can learn a lot from ourselves through the challenges we face. What is something you are grateful for that challenged/challenges you? ---\n",
        " --- What personal strengths are you grateful for and how have they helped you in life? ---\n",
        " --- What dream or desire of yours are you grateful for and why? ---\n",
        " --- Think about the impact you've had on others. What have you learned from the gratitude they have shared with you? ---\n",
        " --- Take a moment to look outside. What's something you are grateful for in nature? ---\n"
    };
    private int _randomGratitudeIndex; 
    private Stopwatch _sw = new Stopwatch();
    private double _lastFrame;
    public GratitudeActivity() :base()
        {
            SetActivityName("gratitude");
            SetWelcomeString();
            _activityDescription = "This activity will help you \"Count Your Many Blessings\" by having you think and write about gratitude.\n";
            _activityDuration = -1;
        }
    public string GetRandomGratitudePrompt()
    {
        Random rand = new Random();
        _randomGratitudeIndex = rand.Next(0, _gratitudePrompts.Count);
        return _gratitudePrompts[_randomGratitudeIndex];
    }
    public double deltaTime()
    {
        TimeSpan ts = _sw.Elapsed;
        double firstFrame = ts.TotalSeconds;
        double dt = firstFrame - _lastFrame;
        _lastFrame = ts.TotalSeconds;
        return dt;
    }
    public void Gratitude()
    {
        Console.Clear();
        Console.WriteLine(_welcomeString);
        Console.WriteLine(_activityDescription);
        _activityDuration = GetSessionDuration();
        GetReadyToStart();//5 second pause
        Console.WriteLine("Respond to the following prompt:\n");
        Console.WriteLine(GetRandomGratitudePrompt());
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
        Console.WriteLine("\nTime's up!");
        string bufStr = String.Join<string>("", buf);
        
        Console.Write("Here's what you typed: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($" {bufStr}<end>");
        Console.ResetColor();
        Spinner(10);
        WellDone();
        EndMessage();

    }
}