using UnityEngine;

[CreateAssetMenu(menuName ="AI/Behaviors/Constrain")]
public class Constrain : AIBeahvior {
    public override Vector3 DoBehavior (AISystem system, Boid boid) {
        Vector3 force = Vector3.zero;
        Bounds bounds = new Bounds(system.center, system.area);

        if(!bounds.Contains(boid.position)) {
            force = bounds.ClosestPoint(boid.position) - boid.position;
        }

        return force;
    }

}