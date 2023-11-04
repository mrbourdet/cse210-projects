using System;

// Consider the following prompt:
// When you hve something in mind, press enter to continue.

public class ReflectingActivity :Activity
{
    private List<string> _reflectingPrompts = new List<string>
    {
        " --- Think of a time when you stood up for someone else. ---\n",
        " --- Think of a time when you did something really difficult. ---\n",
        " --- Think of a time when you helped someone in need. ---\n",
        " --- Think of a time when you did something truly selfless. ---\n"
    };
    private List<string> _ponderingPrompts = new List<string>
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
    };
    private int _randomPromptIndex = 0;
    private int _randomPonderIndex = 0;
  
    public ReflectingActivity() :base()
    {
        SetActivityName("reflecting");
        SetWelcomeString();
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n";

    }
    public string GetRandomReflectingPrompt()
    {
        Random rand = new Random();
        _randomPromptIndex = rand.Next(0, _reflectingPrompts.Count);
        return _reflectingPrompts[_randomPromptIndex];
    }
    public string GetRandomPonderingPrompt()
    {
        Random random = new Random();
        _randomPonderIndex = random.Next(_ponderingPrompts.Count);
        return _ponderingPrompts[_randomPonderIndex];
    }
    public void Reflecting()
    {
        Console.Clear();
        Console.WriteLine(_welcomeString);
        Console.WriteLine(_activityDescription);
        _activityDuration = GetSessionDuration();
        GetReadyToStart();//5 second pause
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(GetRandomReflectingPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions as they related to this experience.\nYou may begin in: ");
        CountdownTimer(5);
        Console.Clear();

        DateTime StartTime = DateTime.Now; //Start timer
        DateTime EndTime = StartTime.AddSeconds(_activityDuration);
    
        do
        {
            Console.Write(GetRandomPonderingPrompt());
            Spinner(10);
            Console.WriteLine();
        } while (DateTime.Now < EndTime);
        WellDone();
        EndMessage();

    }
}