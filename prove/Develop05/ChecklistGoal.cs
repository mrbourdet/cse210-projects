using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class ChecklistGoal :Goal
{
    private int _checkPoints;
    private int _goalNTimes;
    public ChecklistGoal () :base()
    {
        
    }

    public ChecklistGoal (string goalType, string goalName, string goalDesc, int goalPoints) :base()
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalAttained = false;
        _goalComplete = false;
        _checkPoints = 0;
        _goalNTimes = 0; 
    }
}