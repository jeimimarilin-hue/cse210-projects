using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public List<Goal> GetGoals() => _goals;
    public int GetScore() => _score;
    public void AddGoal(Goal goal) => _goals.Add(goal);
    public void RecordEvent(int index) 
    { 
        _goals[index].RecordEvent(); 
        _score += 50; 
    }
    public void LoadGoals(string[] lines) { }
}