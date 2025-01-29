
public enum ActionType
{
    Shop,
    Battle,
    Research
}

public interface IAction
{
    void Execute();
    void Undo();
    ActionType GetActionType();
}
