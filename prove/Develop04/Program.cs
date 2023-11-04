using System;
using System.ComponentModel.Design;
using System.Diagnostics;

// --------------------------------------
// Project:     Mindfulness
// Author:      Michael Bourdet
// Class:       CSE210 - Programming with Classes
// Section:     A5
// Teacher:     Christopher Pitts
// -------------------------------------- 
class Program
{
    static void Main(string[] args)
    { 
        bool showMenu = true;
            while (showMenu) //loop until false
            {
                showMenu = MainMenu();
            }
    }
    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("    1. Start Breathing Activity");
        Console.WriteLine("    2. Start Reflecting Activity");
        Console.WriteLine("    3. Start Listing Activity");
        Console.WriteLine("    4. Start Gratitude Activity");
        Console.WriteLine("    5. Quit");
        Console.WriteLine("Select a choice from the menu: ");

        switch (Console.ReadLine())
        {
            case "1":
                BreathingActivity act = new BreathingActivity(); //Instantiate Breathing Activity
                act.Breathing(); //Run Breathing Activity
                return true;
            case "2":
                ReflectingActivity act2 = new ReflectingActivity(); //Instantiate Reflecting Activity
                act2.Reflecting(); //Run Reflecting Activity
                return true;
            case "3":
                ListingActivity act3 = new ListingActivity(); //Instantiate Listing Activity
                act3.Listing(); //Run Listing Activity
                return true;
            case "4":
                GratitudeActivity act4 = new GratitudeActivity(); //Instantiate Gratitude Activity
                act4.Gratitude(); //Run Listing Activity
                return true;
            case "5": //Ends menu by returning true
                return false;
            default:
                return true;
        }

    }
}