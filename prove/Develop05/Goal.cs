using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Goal
{
    protected static List<string> _goals = new List<string>();
    protected static List<string> _goalsToRecord = new List<string>();
    protected static List<string> _goalsToSave = new List<string>();
    protected static int _totalPoints = 0;
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesc;
    protected int _goalPoints;
    protected bool _goalComplete;

    public Goal ()
    {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
        _goalComplete = false;
    }

    public string GetGoalName() 
    {
        return _goalName;
    } 
    public string GetGoalDesc() 
    {   
        return _goalDesc;
    } 
    public static void DisplayGoalsToComplete() 
    {
        foreach (string line in _goalsToRecord)
        {
            Console.WriteLine(line);
        };
    } 
    public static string GetGoalTypeFromList(int goalIndex) 
    {   
        string goalRecord = _goalsToSave[goalIndex];
        string[] goalParts = goalRecord.Split(",");
        return goalParts[0];
    } 
    public bool GetGoalComplete() 
    {   
        return _goalComplete;
    } 
    public static int GetTotalPoints()
    {
        return _totalPoints;
    }

    public static void ListGoals()
    {
        Console.WriteLine("The goals are:\n");
        foreach (string line in _goals)
        {
        Console.WriteLine(line);
        }
    }
    public static void SaveGoals()
    {
        string fileName = "";
        while (1==1)
        {
            Console.Write("What is the name of the file you want to save? ");
            fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                Console.WriteLine("That file already exists. Overwrite? y/n");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    break;
                }
                else
                {
                    continue;
                } 
            }
            break;
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (string line in _goalsToSave)
            {
                outputFile.WriteLine(line);
            }
        }
    }
    public static void LoadGoals()
    {
        _goals.Clear();
        _goalsToRecord.Clear();
        _goalsToSave.Clear();
        string goalComplete = "false";
        string xlMark = " ";
        string fileName = "";
        while (1==1)
        {
            Console.Write("What is the name of the file you want to load? ");
            fileName = Console.ReadLine();
            if (!File.Exists(fileName))
            {
                Console.WriteLine("That file does not exist. Choose another file.");
                Console.Write("Press any key to continue.");
                Console.ReadLine();
                continue;
            }
            break;
        }

        string[] lines = System.IO.File.ReadAllLines(fileName);
        _totalPoints = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDesc = parts[2];
            int goalPoints = int.Parse(parts[3]);
            if (goalType == "Simple")
            {
                if (parts[4]=="true")
                {
                    xlMark = "X";
                    goalComplete = "true";
                }

                _goals.Add($"{_goals.Count() + 1}. [{xlMark}] {goalName}: {goalDesc}");
                _goalsToRecord.Add($"{_goals.Count()}. {goalName}");
                _goalsToSave.Add($"{goalType},{goalName},{goalDesc},{goalPoints},{goalComplete}");
            }
            else if (goalType == "Eternal")
            {
                _goals.Add($"{_goals.Count() + 1}. [ ] {goalName}: {goalDesc}");
                _goalsToRecord.Add($"{_goals.Count()}. {goalName}");
                _goalsToSave.Add($"{goalType},{goalName},{goalDesc},{goalPoints},false");
            }
            else
            {
                int bonusPoints = int.Parse(parts[4]);
                int goalCompleteTimes = int.Parse(parts[5]);
                int goalAttainedTimes = int.Parse(parts[6]);
                if (goalAttainedTimes >= goalCompleteTimes)
                {
                    xlMark = "X";
                }
                _goals.Add($"{_goals.Count() + 1}. [{xlMark}] {goalName}: {goalDesc}  -- Currently completed: {goalAttainedTimes}/{goalCompleteTimes}");
                _goalsToRecord.Add($"{_goals.Count()}. {goalName}");
                _goalsToSave.Add($"{goalType},{goalName},{goalDesc},{goalPoints},{bonusPoints},{goalCompleteTimes},{goalAttainedTimes}");
            }
            
        }
    }

    public virtual void CreateNewGoal(string goalType)
    {
        _goalType = goalType;
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        string xMark = "";
        if (_goalComplete) {xMark="X";} else {xMark=" ";}
        _goals.Add($"{_goals.Count() + 1}. [{xMark}] {_goalName}: {_goalDesc}");
        _goalsToRecord.Add($"{_goals.Count()}. {_goalName}");
        _goalsToSave.Add($"{_goalType},{_goalName},{_goalDesc},{_goalPoints}, {_goalComplete}");
        _goalComplete = false;
    } 
    public virtual void RecordEvent(string goalType, int goalIndex)
    {
        string goalToEdit = _goalsToSave[goalIndex];
        string item = _goals[goalIndex];
        string itemPlace = item.Substring(0,1);
        string[] parts = goalToEdit.Split(",");
        _goalsToSave[goalIndex] = ($"{parts[0]},{parts[1]},{parts[2]}, {parts[3]},true");
        _goals[goalIndex] = ($"{itemPlace}. [X] {parts[1]}, {parts[2]}");
        _totalPoints += int.Parse(parts[3]);

        Console.WriteLine($"Congatulations! You have earned {parts[3]} points!");
    }
}