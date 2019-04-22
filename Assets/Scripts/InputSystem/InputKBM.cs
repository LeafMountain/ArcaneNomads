using UnityEngine;

[CreateAssetMenu(menuName = "Input/KBM")]
public class InputKBM : InputController, IInputController
{
    public string Jump = "Jump";
    public string Horizontal = "Horizontal";
    public string Vertical = "Vertical";
    public string Sprint = "Fire3";
    public string Interact = "Interact";
    public string Use = "Use";

    public override bool GetJumpInput()
    {
        return Input.GetButtonDown(Jump);
    }

    public override Vector2 GetMoveIntup()
    {
        float h = Input.GetAxisRaw(Horizontal);
        float v = Input.GetAxisRaw(Vertical);
        return new Vector2(h, v);
    }

    public override bool GetSprintInput()
    {
        return Input.GetButton(Sprint);
    }

    public override bool GetInteractButton()
    {
        return Input.GetButtonDown(Interact);
    }

    public override bool GetUseButton()
    {
        return Input.GetButtonDown(Use);
    }
}
