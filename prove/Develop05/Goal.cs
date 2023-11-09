using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesc;
    protected int _points;
    protected bool _goalAttained;
    protected bool _goalComplete;
    protected List<_goal> _goals = new List<string>;
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
        _goalAttained = false;
        _goalComplete = false; 
    }
    public GoalType(string) {get; set;}
    public GoalName(string) {get; set;} 
    public GoalDesc(string) {get; set;} 
    public Points(int) {get; set;} 
    public GoalComplete(bool) {get; set;} 

    public void CreateGoalSubMenu
    {
        string response;
        Console.WriteLine("The types of goals are:\n");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");


        Console.Write("Which type of goal would you like to create? ");
        switch (Console.ReadLine())
        {
        case "1" :
            return true;
        case "2":
            return true;
        case "3":
            return true;
        default:
            return false;
        }
    }



    What is the name of your goal?
    }
    public void ListGoals()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
    public void ecordEvent()
    {

    }

    public abstract CreateNewGoal()
    {

    } 
    public abstract CalculateReward()
    {

    }
    public abstract RecordEvent()
    {

    }



}