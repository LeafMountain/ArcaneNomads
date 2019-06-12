using UnityEngine;
using UnityEngine.Events;

public class Tool : MonoBehaviour, ITool
{
    public UnityEvent OnUse;

    public void Use(ToolUser instagator)
    {
        OnUse.Invoke();
    }
}