using System;
using System.ComponentModel.Design;
using System.Diagnostics;

//  Menu Options
//      1. Start Breathing Activity
//      2. Start Reflecting Activity
//      3. Start Listing Activity
//      4. Quit
//  Select a choice from the menu: 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        // act.DotsTimer(5);
        // act.CountdownTimer(5);
        // act.Spinner(10);


    }
    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("    1. Start Breathing Activity");
        Console.WriteLine("    2. Start Reflecting Activity");
        Console.WriteLine("    3. Start Listing Activity");
        Console.WriteLine("    4. Quit");
        Console.WriteLine("Select a choice from the menu: ");

        switch (Console.ReadLine())
    {
        case "1":
            BreathingActivity act = new BreathingActivity();
            act.Breathing();
            return true;
        case "2":
            Activity act2 = new Activity();
            act2.SetActivityName("reflecting");
            act2.SetActivityDecription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            act2.SetWelcomeString("reflecting");
            //Console.WriteLine(act2.GetActivityName());
            Console.WriteLine(act2.GetWelcomeString());
            Console.WriteLine(act2.GetActivityDescription());
            act2.GetSessionDuration();
            return false;
        case "3":
            Activity act3 = new Activity();
            act3.SetActivityName("listing");
            act3.SetActivityDecription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            act3.SetWelcomeString("listing");
            //Console.WriteLine(act3.GetActivityName());
            Console.WriteLine(act3.GetWelcomeString());
            Console.WriteLine(act3.GetActivityDescription());
            return false;
        case "4":
            return false;
        default:
            return true;
    }

    }
}