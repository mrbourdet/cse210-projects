using System;
using System.ComponentModel.Design;
using System.Diagnostics;

// --------------------------------------
// Project:     Goals
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
    static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.WriteLine("Select a choice from the menu: ");

        switch (Console.ReadLine())
        {
            case "1":
                Goal goal1 = new Goal(); //Instantiate a goal
                goal1.ShowSubMenu();
                return true;
            case "2":
                Goal goal2 = new Goal(); //Instantiate a goal
                goal2.ListGoals();
                return true;
            case "3":
                // ListingActivity act3 = new ListingActivity(); //Instantiate Listing Activity
                // act3.Listing(); //Run Listing Activity
                return true;
            case "4":
                // GratitudeActivity act4 = new GratitudeActivity(); //Instantiate Gratitude Activity
                // act4.Gratitude(); //Run Listing Activity
                return true;
            case "5":
                // GratitudeActivity act4 = new GratitudeActivity(); //Instantiate Gratitude Activity
                // act4.Gratitude(); //Run Listing Activity
                return true;
            case "6": //Ends menu by returning true
                return false;
            default:
                return true;
        }

    }
}