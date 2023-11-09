using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class SimpleGoal :Goal
{
    public SimpleGoal () :base()
    {
        _goalType = "Simple";
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalAttained = false;
        _goalComplete = false; 
    }

    public SimpleGoal (string goalType, string goalName, string goalDesc, int goalPoints) :base()
    {
        _goalType = "Simple";
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalAttained = false;
        _goalComplete = false; 
    }
}