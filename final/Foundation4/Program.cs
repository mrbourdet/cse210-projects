using System;

class Program
{
    public static List<Activity> activities = new List<Activity>();
    static void Main(string[] args)
    {
        Running running1 = new Running("Running", "30 Dec 2023", 60, 4);
        activities.Add(running1);
        Cycling cycling1 = new Cycling("Cycling", "30 Dec 2023", 60, 12);
        activities.Add(cycling1);
        Swimming swimming1 = new Swimming("Swimming", "30 Dec 2023", 20, 20);
        activities.Add(swimming1);
        
        // Display results
        Console.Clear();
        Console.WriteLine("Program 4: Polymorphism with Exercise Tracking");
        Console.WriteLine("---------------------------------------------------------------------------------");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
        Console.WriteLine();
    }
}