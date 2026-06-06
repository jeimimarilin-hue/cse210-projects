public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string desc, string pts, int target, int bonus) : base(name, desc, pts) { _target = target; _bonus = bonus; }
    public override void RecordEvent() { _amountCompleted++; }
    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailsString() => $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
}