using UnityEngine;

[CreateAssetMenu(menuName ="AI/Behaviors/Constrain")]
public class AIConstrain : AIBeahvior {
    public Vector3 center;
    public Vector3 area;

    public override Vector3 DoBehavior (AIComponent boid) {
        Vector3 force = Vector3.zero;
        Bounds bounds = new Bounds(center, area);

        if(!bounds.Contains(boid.transform.position)) {
            Vector3 position = boid.GetComponent<Rigidbody>().position;
            force = bounds.ClosestPoint(position) - position;
        }

        return force.normalized;
    }

}