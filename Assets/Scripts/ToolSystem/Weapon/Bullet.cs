using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent, RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    public int damage;
    public float speed;
    public Vector3 direction;
    public Weapon instagator;

    public void Init(int damage, float speed, Vector3 direction, Weapon instagator)
    {
        this.damage = damage;
        this.speed = speed;
        this.direction = direction.normalized;
        this.instagator = instagator;
        GetComponent<Rigidbody>().velocity = direction * speed;
        Destroy(gameObject, 10);
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction.normalized, out hit, speed * Time.fixedDeltaTime))
        {
            IDamageable target = hit.transform.GetComponent<IDamageable>();
            if (target != null)
            {
                target.Hit(instagator, damage);
            }

            Destroy(gameObject);
        }
    }
}
