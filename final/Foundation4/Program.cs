using System;

class Program
{
    public static List<Activity> activities = new List<Activity>();
    static void Main(string[] args)
    {
        Running running1 = new Running("Running", "30 Dec 2023", 60, 4); //Running(string activityType, string date, int lengthInMinutes, double distanceInKm)
        activities.Add(running1);
        Cycling cycling1 = new Cycling("Cycling", "31 Dec 2023", 60, 15);//Cycling(string activityType, string date, int lengthInMinutes, double speedInKph)
        activities.Add(cycling1);
        Swimming swimming1 = new Swimming("Swimming", "1 Jan 2024", 20, 20); //Swimming(string activityType, string date, int lengthInMinutes, int laps)
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