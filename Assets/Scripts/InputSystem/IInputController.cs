using UnityEngine;

public interface IInputController
{
    Vector2 GetMoveIntup(Transform transform);
    bool GetSprintInput();
    bool GetJumpInput();
    bool GetInteractButton();
    bool GetUseButton();
}
