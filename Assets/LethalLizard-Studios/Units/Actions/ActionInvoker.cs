using System.Collections.Generic;
using UnityEngine;

public class ActionInvoker : MonoBehaviour
{
    private Stack<IAction> _actionHistory = new Stack<IAction>();

    public void ExecuteAction(IAction action)
    {
        action.Execute();
        _actionHistory.Push(action);
    }

    public void UndoLastAction()
    {
        if (_actionHistory.Count > 0)
        {
            IAction lastAction = _actionHistory.Peek();

            // Only allow undos if last is shop phase.
            if (lastAction.GetActionType() == ActionType.Shop)
            {
                _actionHistory.Pop().Undo();
            }
        }
    }
}
