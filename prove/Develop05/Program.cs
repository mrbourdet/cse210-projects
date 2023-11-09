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
    private static bool MainMenu()
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
                private static bool SubMenu()
            {
                Console.Clear();
                Console.WriteLine("Menu Options");
                Console.WriteLine("    1. Create New Simple Goal");
                Console.WriteLine("    2. Create New Eternal Goal");
                Console.WriteLine("    3. Create New Checklist Goal");
                Console.WriteLine("    4. Back to Main Menu");

                Console.WriteLine("Select a choice from the menu: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        // SimpleGoal s = new SimpleGoal(); //Instantiate Breathing Activity
                        // s.Breathing(); //Run Breathing Activity
                        return true;
                    case "2":
                        // ReflectigAcntivity e = new ReflectingActivity(); //Instantiate Reflecting Activity
                        // act2.Reflecting(); //Run Reflecting Activity
                        return true;
                    case "3":
                        // ListingActivity act3 = new ListingActivity(); //Instantiate Listing Activity
                        // act3.Listing(); //Run Listing Activity
                        return true;
                    case "4": //Ends menu by returning true
                        return false;
                    default:
                        return true;
                }

            }
                // act.Breathing(); //Run Breathing Activity
                return true;
            case "2":
                // ReflectingActivity act2 = new ReflectingActivity(); //Instantiate Reflecting Activity
                // act2.Reflecting(); //Run Reflecting Activity
                return true;
            case "3":
                // ListingActivity act3 = new ListingActivity(); //Instantiate Listing Activity
                // act3.Listing(); //Run Listing Activity
                return true;
            case "4":
                // GratitudeActivity act4 = new GratitudeActivity(); //Instantiate Gratitude Activity
                // act4.Gratitude(); //Run Listing Activity
                return true;
            case "5": //Ends menu by returning true
                return false;
            default:
                return true;
        }

    }
}