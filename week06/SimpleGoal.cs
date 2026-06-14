public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string desc, string pts) : base(name, desc, pts) { }
    public override void RecordEvent() => _isComplete = true;
    public override bool IsComplete() => _isComplete;
    public override string GetDetailsString() => $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    public override string GetStringRepresentation() => $"SimpleGoal:{_shortName}|{_description}|{_points}|{_isComplete}";
}