using System;
using UnityEngine;

public abstract class InputController : ScriptableObject, IInputController
{
    public virtual bool GetInteractButton()
    {
        return false;
    }

    public virtual bool GetJumpInput()
    {
        return false;
    }

    public virtual Vector2 GetMoveIntup(Transform transform)
    {
        return Vector3.zero;
    }

    public virtual bool GetSprintInput()
    {
        return false;
    }

    public virtual bool GetUseButton()
    {
        return false;
    }
}
