using System;
using UnityEngine;

public abstract class InputController : ScriptableObject, IInputController
{
    public virtual bool GetInteractButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetJumpInput()
    {
        throw new System.NotImplementedException();
    }

    public virtual Vector2 GetMoveIntup()
    {
        throw new System.NotImplementedException();
    }

    public virtual bool GetSprintInput()
    {
        throw new System.NotImplementedException();
    }

    public virtual bool GetUseButton()
    {
        throw new NotImplementedException();
    }
}
