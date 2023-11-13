using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesc;
    protected int _goalPoints;
    protected bool _goalAttained;
    protected bool _goalComplete;
    protected List<Goal> _goals = new List<Goal>();
    protected string _typePrompt;

    public Goal ()
    {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
        _goalAttained = false;
        _goalComplete = false;
    }
    public Goal (string goalType, string goalName, string goalDesc, int goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalComplete = false; 
    }

    public void SetGoalType(string goalType) 
    {
        _goalType = goalType;
    }
    public string GetGoalType() 
    {
        return _goalType;
    }
    public void GetGoalName(string goalName) 
    {
        _goalName = goalName;
    } 
    public string SetGoalName() 
    {
        return _goalName;
    } 
    public void SetGoalDesc(string goalDesc) 
    {   
        _goalDesc = goalDesc;
    } 
    public string GetGoalDesc() 
    {   
        return _goalDesc;
    } 
    public void SetGoalPoints(int goalPoints) 
    {
        _goalPoints = goalPoints;
    } 
    public int GetGoalPoints() 
    {
        return _goalPoints;
    } 
    public void SetGoalComplete(bool goalComplete) 
    {
        _goalComplete = goalComplete;
    } 
    public bool GetGoalComplete()
    {
        return _goalComplete;
    } 

    //What is the name of your goal?
    public void ListGoals()
    {
        Console.WriteLine("Test");

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }

    public virtual void CreateNewGoal()
    {
        Goal g1 = new Goal();
        Console.Write("What is the name of your goal? ");
        g1._goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        g1._goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        g1._goalPoints = int.Parse(Console.ReadLine());
        _goalComplete = false;
        _goals.Add(g1);
    } 
    public virtual void CalculateReward()
    {

    }
    public virtual void RecordEvent()
    {

    }

    public void ShowSubMenu()
    {
        bool showSubMenu = true;
            while (showSubMenu) //loop until false
            {
                showSubMenu = SubMenu();
            }
        static bool SubMenu()
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
                    SimpleGoal s = new SimpleGoal(); //Instantiate Simple Goal
                    s.CreateNewGoal();
                    return true;
                case "2":
                    // EternalGoal e = new EternalGoal(); //Instantiate Eternal Goal
                    // e.CreateNewGoal();
                    return true;
                case "3":
                    // CheklistGoal c = new ChecklistGoal(); //Instantiate Checklist Goal
                    // c.CreateNewGoal();
                    return true;
                case "4": //Ends menu by returning true
                    return false;
                default:
                    return true;
            }
        }
    }
}