using UnityEngine;

public interface IInputController
{
    Vector2 GetMoveIntup();
    bool GetSprintInput();
    bool GetJumpInput();
    bool GetInteractButton();
    bool GetUseButton();
}
