using System.Diagnostics;

public class Activity //Base Class for BreathingActivity, ReflectingActivity, and ListingActivity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;
    protected string _welcomeString;
    protected DateTime _startTime;

    public Activity ()
    {
        // _activityName = "";
        // _activityDescription = "";
        // _activityDuration = 0;
        // _welcomeString = "";
        // _startTime = DateTime.Now;
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
    public void SetWelcomeString()
    {
        _welcomeString = $"Welcome to the {_activityName} Activity"+"\n";
    }
    public string GetWelcomeString()
    {
        return _welcomeString;
    }
    public int GetSessionDuration()
    {
        Console.Write($"How long, in seconds, would you like for your session? ");
        int input = Int32.Parse(Console.ReadLine());
        return input;
    }
    public void CountdownTimer(int seconds)
    {
        Console.CursorVisible = false; //Hide the cursor for a smoother animation
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true; //Show cursor when finished
    }
    public void DotsTimer(int seconds)
    {
        Console.CursorVisible = false; //Hide the cursor for a smoother animation
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true; //Show cursor when finished
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
        Console.CursorVisible = false; //Hide the cursor for a smoother animation
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.CursorVisible = true; //Show cursor when finished
    }
    
    public void GetReadyToStart ()
    {
        Console.Clear();
        Console.Write("Get ready...");
        CountdownTimer(5);
        Console.WriteLine();
    }
    public void WellDone()
    {
        Console.Write("Well done!!");
        Spinner(5);
        Console.WriteLine();
    }
    public void EndMessage()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"You have completed {_activityDuration} seconds of the {_activityName} activity.");
        Console.ResetColor();
        Spinner(5);
        Console.WriteLine();
    }
}