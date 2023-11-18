using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;

public class ChecklistGoal :Goal
{
    private int _bonusPoints;
    private int _goalCompleteTimes;
    private int _goalAttainedTimes;
    public ChecklistGoal () :base()
    {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
        _goalComplete = false;
        _bonusPoints = 0;
        _goalCompleteTimes = 0;
        _goalAttainedTimes = 0;
    }
        public int GetBonusPoints()
        {
            return _bonusPoints;
        }
        public void SetBonusPoints(int bonusPoints)
        {
            _bonusPoints = bonusPoints;
        }
        public int GetGoalCompleteTimes()
        { 
            return _goalCompleteTimes;
        }
        public void SetGoalCompleteTimes(int goalCompleteTimes)
        { 
            _goalCompleteTimes = goalCompleteTimes;
        }
        public int GetGoalAttainedTimes()
        {
            return _goalAttainedTimes;
        }
        public void SetGoalAttainedTimes(int goalAttainedTimes)
        {
            _goalAttainedTimes = goalAttainedTimes;
        }

    public override void CreateNewGoal(string goalType)
    {
        _goalType = goalType;
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalCompleteTimes = int.Parse(Console.ReadLine());
        Console.Write($"What is the amount of points for completing the goal {_goalCompleteTimes} times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        _goalAttainedTimes = 0;
        string cxMark = "";
        if (GetGoalComplete()){cxMark="X";} else {cxMark=" ";}
        _goals.Add($"{_goals.Count() + 1}. [{cxMark}] {_goalName} {_goalDesc} -- Currently completed: {_goalAttainedTimes}/{_goalCompleteTimes}");
        _goalsToRecord.Add($"{_goals.Count()}. {_goalName}");
        _goalsToSave.Add($"{_goalType},{_goalName},{_goalDesc},{_goalPoints},{_bonusPoints},{_goalCompleteTimes},{_goalAttainedTimes}");
        _goalComplete = false;
    } 
        public override void RecordEvent(string goalType, int goalIndex)
    {
        string x = " ";
        string item = _goals[goalIndex];
        string itemPlace = item.Substring(0,1);
        string[] parts = _goalsToSave[goalIndex].Split(",");
        int bonus = int.Parse(parts[4]);
        int threshold = int.Parse(parts[5]);
        int attained = int.Parse(parts[6]);
        int goalPoints = int.Parse(parts[3]);
        int newAttained = attained + 1;
        if (newAttained == threshold)
        {
            _totalPoints = _totalPoints + goalPoints + bonus;
            Console.WriteLine($"Congatulations! You have earned {goalPoints + bonus} points!");
            x = "[X]";
        }
        else 
        {
            _totalPoints = _totalPoints + goalPoints;
            Console.WriteLine($"Congatulations! You have earned {goalPoints} points!");
            x = "[ ]";
        }
        _goalsToSave[goalIndex] = $"{parts[0]},{parts[1]},{parts[2]},{goalPoints},{bonus},{threshold},{newAttained}";
        _goals[goalIndex] = $"{itemPlace}. {x} {parts[1]}:{parts[2]} -- Currently completed: {newAttained.ToString("D")}/{threshold}";   
    }
}