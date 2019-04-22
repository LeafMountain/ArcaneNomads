using UnityEngine;

public class UserComponent : MonoBehaviour
{
    public UseableComponent useable;
    public Transform attachPoint;

    public void Use()
    {
        if(useable)
            useable.Use(this);
    }

    public void SetUseable(UseableComponent useable)
    {
        this.useable = useable;
        useable.transform.parent = attachPoint;
        useable.transform.rotation = attachPoint.rotation;
        useable.transform.position = attachPoint.position;
    }
}
