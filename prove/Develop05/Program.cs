using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {     
        Console.Clear();
        ShowMenu();
    }

    static bool SubMenu()
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("    1. Create New Simple Goal");
            Console.WriteLine("    2. Create New Eternal Goal");
            Console.WriteLine("    3. Create New Checklist Goal");

            Console.Write("Select a choice from the menu: ");
            switch (Console.ReadLine())
            {
                case "1":
                    SimpleGoal s = new SimpleGoal(); //Instantiate Simple Goal
                    s.CreateNewGoal("Simple");
                    return false;
                case "2":
                    EternalGoal e = new EternalGoal(); //Instantiate Eternal Goal
                    e.CreateNewGoal("Eternal");
                    return false;
                case "3":
                    ChecklistGoal c = new ChecklistGoal(); //Instantiate Checklist Goal
                    c.CreateNewGoal("Checklist");
                    return false;
                default:
                    return true;
            }
        }
    
    public static void ShowMenu()
    {
        bool showMenu = true;
        while (showMenu) //loop until false
        {
            showMenu = Menu();
        }
        static bool Menu()
        {
            Console.WriteLine();
            Console.WriteLine($"You have {Goal.GetTotalPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the menu: ");

            switch (Console.ReadLine())
            {
                case "1":
                    bool showSubMenu = true;
                    while (showSubMenu) //loop until false
                    {
                        showSubMenu = SubMenu();
                    }
                    return true;
                case "2":
                    Goal.ListGoals();
                    return true;
                case "3":
                    Goal.SaveGoals();
                    return true;
                case "4":
                    Goal.LoadGoals();
                    return true;
                case "5":
                    int goalIndex = 0;
                    Console.WriteLine("The Goals are: ");
                    Goal.DisplayGoalsToComplete();
                    Console.Write("Which goal did you accomplish? ");
                    goalIndex = int.Parse(Console.ReadLine()) - 1;
                    string extractedGoalType = Goal.GetGoalTypeFromList(goalIndex);
                    if (extractedGoalType == "Simple")
                    {
                        SimpleGoal sg = new SimpleGoal(); //Instantiate Simple Goal
                        sg.RecordEvent("Simple", goalIndex);
                    }
                    else if (extractedGoalType == "Eternal")
                    {
                        EternalGoal eg = new EternalGoal(); //Instantiate Eternal Goal
                        eg.RecordEvent("Eternal", goalIndex);
                    }
                    else
                    {
                        ChecklistGoal cg = new ChecklistGoal(); //Instantiate Eternal Goal
                        cg.RecordEvent("Checklist", goalIndex);
                    }
                    return true;
                case "6": //Ends menu by returning true
                    return false;
                default:
                    return true;
            }
        }
    }
}
