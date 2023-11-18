using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class EternalGoal :Goal
{
    public EternalGoal () :base()
    {

    }
public override void RecordEvent(string goalType, int goalIndex)
    {
        string goalToEdit = _goalsToSave[goalIndex];
        string[] parts = goalToEdit.Split(",");
        _totalPoints += int.Parse(parts[3]);

        Console.WriteLine($"Congatulations! You have earned {parts[3]} points!");
    }
        
}