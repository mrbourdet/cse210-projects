using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class EternalGoal :Goal
{
    public EternalGoal () :base()
    {

    }

    public EternalGoal (string goalType, string goalName, string goalDesc, int goalPoints) :base()
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalAttained = false;
        _goalComplete = false; 
    }
}