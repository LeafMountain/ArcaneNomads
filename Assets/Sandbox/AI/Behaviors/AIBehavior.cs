using UnityEngine;

[System.Serializable]
public class AIBeahvior : ScriptableObject {
    public virtual Vector3 DoBehavior(AISystem system, Boid boid){
        return Vector3.zero;
    }
}

