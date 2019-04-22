using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{
    public Quaternion currentRotation;

    [Range(-1, 1)]
    public float W;
    
    void Update()
    {
        currentRotation.w = W;
        transform.rotation = currentRotation;
    }

    void OnDrawGizmosSelected()
    {
        Update();
    }
}
