using System;
// Program:     Journal
// Author:      Michael R. Bourdet
// Date:        20231007
// Class:       CSE210
// Instructor:  Brother Pitts
// 
// Shows Creativity:  I used a switch-case statement rather than if...else if...else.  
// The default case checks for invalid input and displays the message in red text.
// I added more questions to the list of prompts.
// I saved the data file to a .csv format that can be opened in Excel.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        DisplayWelcome();
        
        string responseFromUser = "";
        Journal userEntry = new Journal(); 
        while (responseFromUser != "5") 
        {

            responseFromUser = DisplayMenu();
            // https://www.w3schools.com/cs/cs_switch.php
            switch (responseFromUser)
            {
            case "1":
                // add date, prompt and response to list
                userEntry.WriteJournal();
                break;
            
            case "2":
            
                // Display list of responses
                userEntry.DisplayJournal();
                break;

            case "3":
            
                // Load list from a .csv file
                userEntry.LoadJournal();
                Console.WriteLine("File has been loaded from write.csv.");
                break;

            case "4":
                //save list to .csv file
                userEntry.SaveJournal();
                Console.WriteLine("File has been saved to write.csv");  
                break;
            
            case "5":
                //quit
                Console.WriteLine($"Bye!");
                break;

            default: //https://www.dotnetperls.com/console-color
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ($"{responseFromUser} is invalid. Please make a valid response.");
                Console.ResetColor();
                break;
            }
        }
        //End
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Journal Program");
    }
    static string DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        return Console.ReadLine();
    }
    
}