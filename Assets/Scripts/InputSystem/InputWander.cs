using UnityEngine;

[CreateAssetMenu]
public class InputWander : InputController, IInputController
{


    public override bool GetJumpInput()
    {
        return Random.Range(0, 100) < 1;
    }

    public override Vector2 GetMoveIntup(Transform transform)
    {        
        return Vector3.right;
    }
}
