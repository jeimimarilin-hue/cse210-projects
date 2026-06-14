public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, string pts) : base(name, desc, pts) { }
    public override void RecordEvent() { }
    public override bool IsComplete() => false;
    public override string GetStringRepresentation() => $"EternalGoal:{_shortName}|{_description}|{_points}";
}